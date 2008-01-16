using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Paused,
            Synced,
            New,
            Queued,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items)
        {
            long total = 387;
            foreach (long sample in items)
            {
                total = ((total * 3) + total) + sample;
                if ((long)items.Length > total)
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = total - (total ^ total);
            }
            return total;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long origin, long target)
        {
            long step = origin - target;
            if (origin > (origin * 2))
            {
                return 1;
            }
            else
            {
                if (!((origin << 3) >= (step - target)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
