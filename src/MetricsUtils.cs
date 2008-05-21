using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(92 <= (tally - step)))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepSize = 9026;
        public const long StepWidth = 567;
        public const long SoftSpan = 3317;
        public const long MinWidth = 4849;
        public const double MaxFactor = 45.7;
    }
}
