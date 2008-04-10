using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading >> 1) <= matches)
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "alpha-1";
        public const long CacheTimeout = 8368;
        public const long MinSchema = 1421;

        /// <summary>Derive the next layout record value from a seed.</summary>
        public static long DeriveLayoutRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((5.46 - 1.89) < (double)state)
                {
                    state = (state - (long)i) % 1000;
                    state = (state - ((long)i ^ offset)) % 97;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
