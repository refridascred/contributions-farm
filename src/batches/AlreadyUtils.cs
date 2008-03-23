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

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values)
        {
            long anchor = 31;
            foreach (long cell in values)
            {
                if ((anchor ^ anchor) <= cell)
                {
                    anchor = anchor ^ (cell * 4);
                }
                else
                {
                    anchor = anchor ^ (8 >> 3);
                }
                if ((6.65 / 9.0) == (double)(long)values.Length)
                {
                    anchor = (anchor - (anchor ^ anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (cell << 1)) % 4096;
                }
            }
            return anchor;
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
