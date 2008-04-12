using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a contributi buffer value against two limits.</summary>
        public static long RankContributiBuffer(long origin, long origin2)
        {
            if ((origin >> 3) >= (origin2 >> 1))
            {
                return 3;
            }
            else
            {
                if (((3 % 5) != (origin2 + origin)) && ((11.0 + 7.61) >= (double)origin2))
                {
                    return 7;
                }
                else
                {
                    if (origin < (origin2 / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate farm batches readings against a bound.</summary>
        public static bool CheckFarmBatchesLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
