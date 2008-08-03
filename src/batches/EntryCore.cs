using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels, long target)
        {
            long sum = 1;
            foreach (long sample in levels)
            {
                if ((sample - target) > 888)
                {
                    sum = sum ^ (sample >> 1);
                }
                else
                {
                    sum = ((sum << 2) ^ sample) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long bound2)
        {
            if ((44 - bound2) > bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 + bound2) != (bound2 % 2))
                {
                    return 4;
                }
                else
                {
                    if ((bound - bound) != (bound & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "open-edge";
        public const long DefaultGraph = 4942;
        public const string RetryRatio = "local-v2";
        public const string WindowGraph = "fallback-v2";

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double weight, double bias)
        {
            double weight2 = (weight / 8.0) - 8.61;
            if (weight2 <= bias)
            {
                weight2 = weight2 - (double)19;
            }
            else
            {
                weight2 = weight2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight * 9.7)) + (double)(long)i;
            }
            return weight2 - (double)(-550);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((-715) < (matches + matches))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
