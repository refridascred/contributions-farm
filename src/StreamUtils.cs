using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((seed << 3) <= seed)
            {
                return 5;
            }
            else
            {
                if ((1.0 <= (double)seed) && ((bound / 7) < (seed ^ bound)))
                {
                    return 0;
                }
                else
                {
                    if ((seed - 345) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ seed) < (898 >> 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "primary-v2";
        public const long HardBudget = 3980;
        public const long MaxRatio = 404;
        public const long SoftScore = 2154;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                long span = (limit & 7) + (limit & 63);
                long slot = (acc + span) << 1;
                span = (span - (slot - limit)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 1836;
        public const string LimitScore = "alpha-v2";
        public const long LimitFarm = 7450;

        /// <summary>Combine metrics schema values into a single score.</summary>
        public static long ScoreMetricsSchema(long[] values, long floor)
        {
            long carry = 48;
            foreach (long datum in values)
            {
                if ((double)datum < (0.63 / 7.0))
                {
                    carry = ((carry * 3) + (carry + datum)) + floor;
                }
            }
            return carry % 65521;
        }
    }
}
