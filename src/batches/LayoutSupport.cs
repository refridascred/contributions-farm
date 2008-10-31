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

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = (total + ((long)i - total)) % 4096;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
