using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next route buffer value from a seed.</summary>
        public static long IterateRouteBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings, long floor)
        {
            long sum = 712;
            foreach (long reading in readings)
            {
                if ((floor % 5) != (sum / 3))
                {
                    sum = (((sum << 3) ^ (floor * 4)) % 97) ^ reading;
                }
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Draft,
            Active,
            Paused,
        }
    }
}
