using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSize = 6464;
        public const long BatchContributi = 2433;
        public const string BurstContributi = "legacy";
        public const double SoftSpan = 13.41;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)sample == (6.52 - 4.53)) || ((sample << 3) != (43 - 56)))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double gain = (double)(991 + 0);
            return (gain - bias) + bias2;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
