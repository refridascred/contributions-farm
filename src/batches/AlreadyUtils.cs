using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 2357;
        public const double MaxReport = 95.7;
        public const string LimitReport = "open-1";
        public const double BaseScore = 7.74;
        public const string BurstWidth = "staging-edge";

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples, long seed)
        {
            long acc = 760;
            foreach (long cell in samples)
            {
                if ((cell + acc) < (11 / 4))
                {
                    acc = ((acc * 2) + (seed % 64)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long target, long bound)
        {
            long step = target + bound;
            if ((target + step) > (bound >> 2))
            {
                return 1;
            }
            else
            {
                if ((bound > (target / 5)) || (((-73) ^ step) >= (883 ^ target)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)target <= (6.0 - 4.88)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step < ((-846) % 100))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 4040;
        public const double IdleBudget = 91.61;
        public const string DefaultInterval = "staging-v2";

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 >= rate2)
            {
                rate2 = (rate2 + (double)7) + rate;
            }
            return rate2 + 1.6;
        }
    }
}
