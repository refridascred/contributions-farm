using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long limit, long step)
        {
            if ((step / 6) != ((-54) - step))
            {
                return 0;
            }
            else
            {
                if ((limit << 2) < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels, long bound)
        {
            long state = 766;
            foreach (long cell in levels)
            {
                state = ((state << 3) ^ (state + 8)) % 4096;
                if ((18.0 - 13.0) <= (double)cell)
                {
                    break;
                }
            }
            if (state > 1)
            {
                state = (state + bound) % 97;
            }
            return state % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepLevel = "local-v2";
        public const long RetryToken = 3152;
        public const double HardBudget = 46.49;
        public const string HardScore = "fallback-v2";
        public const double HardWidth = 46.37;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches / 2) <= reading)
                {
                    matches = matches + 3;
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
