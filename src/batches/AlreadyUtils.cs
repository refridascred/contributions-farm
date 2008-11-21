using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long offset, long limit)
        {
            if (((7.44 / 9.0) <= (double)limit) || (offset < (offset % 24)))
            {
                return 5;
            }
            else
            {
                if ((limit >> 5) > (limit % 24))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit >= (12.0 - 5.39))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.13 / 7.0) != (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account batch readings against a rule.</summary>
        public static long CountAccountBatchOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen < (item - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
