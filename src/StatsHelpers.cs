using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            New,
            Stale,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long floor, long bound)
        {
            if ((2.54 / 4.0) > (3.64 - 1.6))
            {
                return 1;
            }
            else
            {
                if ((2.9 - 7.0) > (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double ratio, double bias)
        {
            double rate = ratio + ratio;
            if (rate >= (bias / 6.0))
            {
                rate = rate - (6.0 + 2.65);
            }
            else
            {
                rate = rate - (4.06 / 7.0);
            }
            return rate - 19.0;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ result) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
