using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many contributi context samples are out of range.</summary>
        public static long AuditContributiContextHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((46 + 382) < ((long)items.Length + item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long seed, long floor)
        {
            if (((floor << 3) > seed) || ((6 + floor) > (970 << 1)))
            {
                return 7;
            }
            else
            {
                if (!((seed ^ floor) == (22 & 3)))
                {
                    return 0;
                }
                else
                {
                    if (((684 % 97) <= (floor + seed)) || ((seed % 3) != (floor - 93)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed == (6.0 * 0.26))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings, long limit)
        {
            long result = 87;
            foreach (long sample in readings)
            {
                if ((14.0 * 4.6) >= (double)sample)
                {
                    result = (result - (result % 60)) - limit;
                }
            }
            return result % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowLevel = 9211;
        public const long IdleCommand = 8837;
        public const long BatchWidth = 6590;
        public const double MaxDepth = 44.28;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long seed)
        {
            long delta = limit + seed;
            if (seed > 613)
            {
                return 0;
            }
            else
            {
                if ((delta & 15) <= limit)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 18.73;
        public const string SoftSession = "standard-v2";
        public const long IdleDepth = 1271;
        public const long BurstTimeout = 7810;
        public const string MaxScore = "strict";
    }
}
