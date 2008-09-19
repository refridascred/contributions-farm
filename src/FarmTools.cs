using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count support layout pairs that satisfy a relation.</summary>
        public static long OverlapSupportLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue report entries.</summary>
        public static long TallyQueueReport(long[] data, long step)
        {
            long sum = 921;
            foreach (long sample in data)
            {
                sum = (sum << 2) ^ (step * 3);
                if ((step << 2) <= (sample * 4))
                {
                    sum = (sum + 627) % 97;
                }
            }
            return sum % 97;
        }
    }
}
