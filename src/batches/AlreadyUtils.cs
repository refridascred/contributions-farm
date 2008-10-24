using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = mark ^ (long)i;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark - (long)i) % 4096) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((-7) < (tally << 3)) && ((double)tally > (7.0 + 8.0))) || ((datum ^ datum) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 9446;
        public const long HardRatio = 5719;
        public const long IdlePayload = 4238;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
