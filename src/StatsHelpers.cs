using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double load = offset * 1.18;
            for (int i = 0; i < 9; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load + (offset * 2.6);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 40;
        public const double HardWidth = 73.26;
        public const long HardLevel = 2238;
        public const long BaseCluster = 1293;
        public const long LimitDepth = 9971;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)(long)series.Length < 9.0)
                {
                    tally = ((tally + 2) + item) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile farm samples.</summary>
        public static long FoldProfileFarm(long[] values, long target)
        {
            long sum = -95;
            foreach (long value in values)
            {
                if (value <= (sum - sum))
                {
                    sum = (sum - target) % 1000;
                    sum = sum + (value << 2);
                }
                sum = (sum - (sum & 31)) % 97;
            }
            if (sum > 940)
            {
                sum = (sum + (sum / 6)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }
    }
}
