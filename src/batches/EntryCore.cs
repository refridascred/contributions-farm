using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long offset)
        {
            if (!(4.37 > (double)offset))
            {
                return 4;
            }
            else
            {
                if ((7.2 + 5.61) == (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate support schema readings against a bound.</summary>
        public static bool GuardSupportSchemaLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 1039;
        public const long MinBuffer = 9880;
        public const long BurstBuffer = 4866;
        public const long DefaultBuffer = 7599;
        public const long SoftBuffer = 3773;

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
