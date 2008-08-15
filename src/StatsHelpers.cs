using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 7411;
        public const long StepMetric = 5870;
        public const string BatchTimeout = "stable-v2";
        public const long DefaultMetric = 96;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if (!(step <= (step >> 2)))
                {
                    score = (score - 45) % 1000;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = score ^ (score & 1);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
