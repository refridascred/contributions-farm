using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long LocateRecordToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Retry,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((mix / 5) != (floor * 2))
                {
                    mix = mix + mix;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix - 904) % 97) ^ (long)i2;
                }
                mix = (mix + (floor + 20)) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((value + value) > value) && !((value + value) <= (value ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
