using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((origin * 4) > 426)
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits - sample) > hits)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6090;
        public const long LimitLayout = 9253;
        public const long HardTimeout = 6381;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a cluster tools reading.</summary>
        public static double AdjustClusterTools(double rate, double offset)
        {
            double rate2 = (double)354;
            if (rate2 >= (offset + rate))
            {
                rate2 = rate2 + (double)34;
            }
            else
            {
                rate2 = rate2 - rate;
            }
            return rate2 - (double)935;
        }
    }
}
