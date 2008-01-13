using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank stats batches input into a small class.</summary>
        public static long SortStatsBatches(long target, long limit)
        {
            if ((limit - 39) > ((-926) / 5))
            {
                return 1;
            }
            else
            {
                if (!((15 >> 3) <= (target % 16)))
                {
                    return 2;
                }
                else
                {
                    if (!((limit ^ (-27)) < (506 + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate farm graph samples.</summary>
        public static long ScoreFarmGraph(long[] data, long target)
        {
            long anchor = -14;
            foreach (long cell in data)
            {
                anchor = ((anchor << 2) ^ (anchor + target)) ^ cell;
            }
            return anchor;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Stale,
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a farm cache sample.</summary>
        public static long LookupFarmCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
