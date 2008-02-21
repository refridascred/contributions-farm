using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 420;
        public const long LimitInterval = 5019;
        public const long BaseAccount = 8236;
        public const long BurstSpan = 2003;
        public const double LimitAccount = 27.06;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((hits % 64) <= item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 5; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + (5.0 - gain);
        }
    }
}
