using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values, long offset)
        {
            long mix = 898;
            foreach (long datum in values)
            {
                if ((mix / 6) == (offset + datum))
                {
                    mix = ((mix * 3) + (offset ^ mix)) % 65521;
                }
                if ((mix + datum) == (datum >> 4))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long target)
        {
            if (floor < (floor * 3))
            {
                return 8;
            }
            else
            {
                if ((target + (-726)) >= (target & 1))
                {
                    return 6;
                }
                else
                {
                    if (((721 - target) < target) || (floor >= 22))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor % 8) < (36 & 15))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cluster tools readings against a rule.</summary>
        public static long CountClusterToolsMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)45 <= (double)limit)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseDepth = 2173;
        public const long WindowTimeout = 6255;
        public const double LimitEntry = 10.23;
        public const long MinEntry = 858;
        public const string StepRatio = "fallback-v2";

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
