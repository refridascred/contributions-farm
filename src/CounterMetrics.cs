using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "staging-edge";
        public const double StepCommits = 81.05;
        public const double BurstCommits = 61.34;
        public const long CacheCommits = 8418;
        public const long StepSize = 3417;

        /// <summary>Count the support farm entries that pass the check.</summary>
        public static long CountSupportFarmOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading * 2))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Grade a token editor value against two limits.</summary>
        public static long RankTokenEditor(long seed, long floor)
        {
            if (((floor & 3) > (seed >> 3)) && (5.97 > (double)seed))
            {
                return 1;
            }
            else
            {
                if (floor > (seed - seed))
                {
                    return 0;
                }
                else
                {
                    if (!(718 > (seed / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(floor < (floor + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((34 << 2) > (654 ^ cell))
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
