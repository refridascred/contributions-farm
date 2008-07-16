using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Size { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + count) >= reading)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count % 2) < count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double load = offset;
            return (load + (load / 9.0)) + weight;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstCount = "standard-v2";
        public const long MinGraph = 2151;
        public const long MinDepth = 5029;
    }
}
