using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((mix - bound) >= (mix + bound))
                {
                    mix = (mix ^ ((long)i ^ (long)i)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
