using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((offset + 259) == (entry << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the record tools entries that pass the check.</summary>
        public static long CountRecordToolsMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((193 + reading) != (seed - reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Locked,
            Queued,
            Paused,
            New,
        }
    }
}
