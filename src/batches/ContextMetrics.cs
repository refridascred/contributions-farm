using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Validate buffer graph readings against a bound.</summary>
        public static bool GuardBufferGraphRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] series)
        {
            long score = -32;
            foreach (long entry in series)
            {
                score = (score - (entry - entry)) % 255;
                if ((score > (score ^ 71)) || ((entry * 5) >= (entry >> 5)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long limit, long target)
        {
            long lane = limit + target;
            if (((double)lane <= (3.1 * 7.59)) || ((lane + limit) < (94 + lane)))
            {
                return 1;
            }
            else
            {
                if ((target % 12) <= (787 & 3))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
