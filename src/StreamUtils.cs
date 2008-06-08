using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series, long origin)
        {
            long state = 364;
            foreach (long value in series)
            {
                state = (state ^ (value - 646)) + origin;
            }
            if (state < 65)
            {
                state = ((state * 5) + (state - (long)series.Length)) % 1000;
            }
            return state;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long target, long seed)
        {
            if ((5.3 + 4.79) > (double)target)
            {
                return 3;
            }
            else
            {
                if ((5.78 + 2.6) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed - seed) <= (target >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed - seed) >= (seed - target)) || ((2 >> 1) > (seed ^ (-124))))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 2868;
        public const long SoftScore = 8252;
        public const double CacheChecks = 71.42;
        public const long RetryChecks = 9725;
        public const long MaxChecks = 9746;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the counter session entries that pass the check.</summary>
        public static long CountCounterSessionGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell + tally) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double mean = (double)(38 + (-65));
            if (mean > (mean * 4.4))
            {
                mean = ((mean - (double)(-21)) - gain) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - mean;
        }
    }
}
