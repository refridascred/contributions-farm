using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Locked,
            Done,
            Draft,
            Idle,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample & 63) != (80 % 7)) && (44 <= sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] series)
        {
            long result = 743;
            foreach (long value in series)
            {
                if ((79 % 16) > (long)series.Length)
                {
                    result = ((result << 3) ^ (value % 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Scale a account session figure with a bias.</summary>
        public static double BlendAccountSession(double scale, double span)
        {
            double bias = (double)7 * 17.0;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (double)597) - (double)(long)i) + span;
            }
            return bias + scale;
        }
    }
}
