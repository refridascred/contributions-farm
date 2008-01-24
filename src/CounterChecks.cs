using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 6006;
        public const long MinCount = 4594;
        public const double RetryQueue = 59.1;
        public const string SoftQueue = "primary-v2";

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the queue tools entries that pass the check.</summary>
        public static long MeasureQueueToolsMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((limit % 100) < hits)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Combine support batch values into a single score.</summary>
        public static long WeighSupportBatch(long[] values)
        {
            long sum = 52;
            foreach (long entry in values)
            {
                if (((long)values.Length << 2) > (entry % 97))
                {
                    sum = sum ^ (entry << 1);
                }
            }
            return sum % 65521;
        }
    }
}
