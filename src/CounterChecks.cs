using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit route editor readings against a rule.</summary>
        public static long CountRouteEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((1.3 * 15.0) == (double)matches) && (item > (-669)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7767;
        public const long LimitSize = 7569;
        public const string BurstInterval = "strict-edge";

        /// <summary>Rank route batches input into a small class.</summary>
        public static long RankRouteBatches(long origin, long origin2)
        {
            if (!((double)origin2 <= (12.0 + 17.0)))
            {
                return 1;
            }
            else
            {
                if ((origin2 % 60) >= (65 * 2))
                {
                    return 4;
                }
                else
                {
                    if (!((origin2 + origin2) > (581 + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin2 == (8.26 / 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long SortProfileBuffer(long seed, long limit)
        {
            if (((double)31 < (double)seed) || ((seed ^ 9) <= (seed % 16)))
            {
                return 0;
            }
            else
            {
                if (((53 + seed) <= seed) || ((double)limit < (9.96 / 4.0)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples)
        {
            long total = 8;
            foreach (long item in samples)
            {
                if ((total - item) > item)
                {
                    total = total - total;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a format notes sample.</summary>
        public static long SeekFormatNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
