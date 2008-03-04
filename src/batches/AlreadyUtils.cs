using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Queued,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Count format report pairs that satisfy a relation.</summary>
        public static long CompareFormatReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account batches readings.</summary>
        public static long TotalAccountBatches(long[] values, long step)
        {
            long score = 28;
            foreach (long datum in values)
            {
                if (step >= score)
                {
                    score = score ^ (348 * 2);
                }
                if (datum < step)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long origin, long seed)
        {
            if ((14 - seed) < (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) <= (origin - seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin == (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch entry readings.</summary>
        public static long CompareBatchEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
