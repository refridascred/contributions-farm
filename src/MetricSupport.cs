using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((matches - datum) < bound) || ((bound % 24) != ((-8) % 8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics batches readings against a rule.</summary>
        public static long AuditMetricsBatchesMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((49 < (item >> 3)) || ((double)count >= (4.0 - 20.0)))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }
    }
}
