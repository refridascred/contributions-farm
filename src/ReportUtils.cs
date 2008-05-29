using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] samples, long seed)
        {
            long total = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length & 7) < seed)
                {
                    total = (total ^ (seed << 2)) - reading;
                }
            }
            return total;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Done,
            Queued,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double gain, double span)
        {
            double load = span;
            if (load > (gain / 6.0))
            {
                load = load + (load / 8.0);
            }
            return load + (double)0;
        }
    }
}
