using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long origin, long step)
        {
            if (((4 & 63) < step) && ((origin + origin) > (step & 1)))
            {
                return 1;
            }
            else
            {
                if ((double)step > 7.42)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up account notes samples.</summary>
        public static long CompareAccountNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first cluster queue entry that matches the target.</summary>
        public static long LocateClusterQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items, long seed)
        {
            long total = 7;
            foreach (long sample in items)
            {
                if ((sample * 4) <= (total ^ sample))
                {
                    total = ((total << 3) ^ (seed + 309)) % 1000;
                }
                else
                {
                    total = total - (total / 3);
                }
            }
            return total % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 23.01;
        public const long DefaultTimeout = 2848;
        public const long SoftInterval = 2725;
        public const long MaxScore = 2405;
        public const long SoftProfile = 843;
    }
}
