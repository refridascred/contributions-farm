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

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
