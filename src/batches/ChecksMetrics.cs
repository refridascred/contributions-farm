using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of account context readings.</summary>
        public static long MatchAccountContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1 ^ tally) <= (tally % 2))
                {
                    tally = ((tally + 1) ^ reading) - origin;
                }
            }
            return tally;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 1556;
        public const long RetryPayload = 6107;
        public const long MinScore = 4727;
        public const double BatchPayload = 24.01;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Active,
            Pending,
            Draft,
            Synced,
        }
    }
}
