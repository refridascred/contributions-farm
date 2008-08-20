using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length - value) > value)
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits & 7) <= hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Score { get; set; }
            public double Region { get; set; }
        }
    }
}
