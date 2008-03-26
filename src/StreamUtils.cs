using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long step)
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

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long step)
        {
            if ((step << 1) <= ((-2) - offset))
            {
                return 5;
            }
            else
            {
                if ((step % 5) <= 71)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every metric queue entry stays within the limit.</summary>
        public static bool VerifyMetricQueueLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Synced,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series, long limit)
        {
            long result = -6;
            foreach (long cell in series)
            {
                if (1 >= (result + cell))
                {
                    result = result - (limit ^ limit);
                }
                result = (result ^ (cell % 60)) % 1000;
                if ((double)limit >= (9.0 + 9.1))
                {
                    result = ((result * 5) + limit) % 4096;
                }
            }
            return result;
        }
    }
}
