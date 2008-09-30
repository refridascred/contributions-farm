using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits > (hits << 3))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Audit record entry readings against a rule.</summary>
        public static long MeasureRecordEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + count) == (value << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstLevel = 2.14;
        public const string DefaultRatio = "alpha-1";
        public const long StepSize = 8935;
        public const string WindowLevel = "staging";
        public const long BatchPayload = 3585;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Active,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
