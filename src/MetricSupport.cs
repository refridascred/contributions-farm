using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double gain, double offset)
        {
            double ratio = (0.11 * 5.0) - (offset - gain);
            return ratio - (double)(-54);
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((reading << 1) == (7 + reading)) || ((matches - reading) < (matches * 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] series, long offset)
        {
            long acc = 5;
            foreach (long reading in series)
            {
                if ((9.09 / 2.0) > (double)offset)
                {
                    acc = ((acc ^ offset) % 255) - reading;
                }
            }
            return acc;
        }
    }
}
