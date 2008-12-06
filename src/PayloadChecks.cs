using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((7.7 + 5.95) <= (double)target)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Stale,
            Active,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((9.1 * 8.1) >= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double scale, double span)
        {
            double bias = scale;
            return bias + (span / 8.0);
        }
    }
}
