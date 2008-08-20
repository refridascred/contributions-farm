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

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double drift = rate;
            if (drift >= (rate - rate))
            {
                drift = (drift - drift) + offset;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - drift;
        }

        /// <summary>Derive the next report payload value from a seed.</summary>
        public static long SeriesReportPayload(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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
