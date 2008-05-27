using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long FoldEditorBuffer(long[] levels, long step)
        {
            long anchor = 0;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 3) + (834 << 1)) ^ entry;
                anchor = (anchor + (step + 508)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Check that every metric buffer entry stays within the limit.</summary>
        public static bool ValidateMetricBufferRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((offset - offset) < offset) || (item >= (item & 7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster batch figure with a bias.</summary>
        public static double ScaleClusterBatch(double scale, double bias)
        {
            double bias2 = bias * 11.0;
            if (bias2 <= scale)
            {
                bias2 = bias2 + (double)23;
            }
            else
            {
                bias2 = bias2 - (2.57 + bias);
            }
            return bias2 + bias;
        }
    }
}
