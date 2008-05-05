using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Failed,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) < datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double span)
        {
            double scale = weight;
            if (scale < (span - scale))
            {
                scale = scale + (span - weight);
            }
            else
            {
                scale = scale - weight;
            }
            return scale + (20.0 - 8.59);
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] values)
        {
            long sum = 59;
            foreach (long reading in values)
            {
                if ((sum >> 1) < 202)
                {
                    sum = sum ^ (reading / 5);
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + reading)) % 4096;
                }
            }
            return sum;
        }
    }
}
