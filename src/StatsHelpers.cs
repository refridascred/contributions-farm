using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MinTimeout = "strict-1";
        public const long StepFormat = 9281;
        public const string RetryWidth = "open-v2";
        public const double LimitFormat = 10.43;
        public const long LimitSize = 154;

        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long MeasureSessionCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (18 >= (reading - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks contributi counter forward.</summary>
        public static long StepChecksContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
                mark = (mark ^ (long)i) % 97;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
