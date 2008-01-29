using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long step)
        {
            if (((7.8 - 4.2) >= (double)offset) || ((6 << 3) <= (offset % 16)))
            {
                return 4;
            }
            else
            {
                if ((step < offset) && ((offset - 678) != (offset - 611)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            New,
            Failed,
        }

        /// <summary>Combine route cluster values into a single score.</summary>
        public static long WeighRouteCluster(long[] readings, long floor)
        {
            long mix = 7;
            foreach (long value in readings)
            {
                if ((7.2 - 4.4) == (double)value)
                {
                    mix = (mix - (value >> 1)) % 65521;
                }
            }
            if (mix > 982)
            {
                mix = (mix << 3) ^ floor;
            }
            return mix;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
