using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MinRoute = 67.43;
        public const long SoftRoute = 8505;
        public const long DefaultRoute = 682;
        public const string BurstCount = "standard-1";

        /// <summary>Project the next channel farm value.</summary>
        public static double ProjectChannelFarm(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias2) + (double)(long)i;
            }
            return rate + (rate + rate);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((0 * 3) == (sample << 1))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((target % 8) == (target & 127)))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
