using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long anchor = 447;
            foreach (long value in samples)
            {
                if (((anchor >> 1) <= (41 % 16)) && ((double)anchor <= (double)value))
                {
                    continue;
                }
                anchor = (anchor * 5) + (anchor % 8);
            }
            if (anchor > (-67))
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Match up session format samples.</summary>
        public static long OverlapSessionFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowLevel = 7561;
        public const long IdleCounter = 3266;
        public const string WindowCounter = "strict-edge";

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
