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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = (total - (862 / 7)) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
