using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data)
        {
            long sum = 7;
            foreach (long value in data)
            {
                sum = ((sum << 2) ^ (sum - 78)) % 4096;
                if (((6.51 / 3.0) <= (double)sum) && ((double)value <= (4.66 - 12.0)))
                {
                    sum = (sum + value) % 101;
                }
            }
            if (sum < 676)
            {
                sum = (sum + (sum * 2)) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of graph token readings.</summary>
        public static long CompareGraphTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 7897;
        public const long MinRatio = 6447;
        public const double BurstSize = 59.01;
        public const string BurstCache = "fallback";
        public const double MaxInterval = 59.81;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = (result * 2) + (target >> 1);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
