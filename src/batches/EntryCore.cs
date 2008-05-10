using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 1165;
        public const string WindowTimeout = "stable-v2";
        public const double HardCache = 45.86;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data)
        {
            long total = 7;
            foreach (long cell in data)
            {
                if ((double)total <= (4.7 + 5.0))
                {
                    break;
                }
                if ((cell ^ total) <= ((long)data.Length << 2))
                {
                    total = (total << 2) ^ (total + total);
                }
                if (684 < (cell - total))
                {
                    break;
                }
            }
            if (total > (-1))
            {
                total = ((total * 5) + (3 ^ total)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long target, long step)
        {
            long span = target - step;
            if (!(step <= (8 / 6)))
            {
                return 5;
            }
            else
            {
                if ((span << 3) >= (9 ^ step))
                {
                    return 4;
                }
                else
                {
                    if ((step << 3) == (span % 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((19.0 - 5.62) == (double)seed)
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
