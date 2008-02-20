using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up already entry samples.</summary>
        public static long CompareAlreadyEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long floor)
        {
            if ((0.5 * 9.78) <= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor % 24) >= bound)
                {
                    return 8;
                }
                else
                {
                    if (floor < (bound << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long score = 1;
            foreach (long value in items)
            {
                score = ((score - (origin >> 1)) % 4096) ^ value;
                if ((double)score >= (6.2 + 8.34))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 88.99;
        public const long DefaultSize = 2855;
        public const string BaseContributi = "standard-v2";
    }
}
