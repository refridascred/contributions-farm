using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two channel support measurements.</summary>
        public static double SmoothChannelSupport(double scale, double offset)
        {
            double bias = (scale / 2.0) / 8.0;
            if (bias <= bias)
            {
                bias = bias - (bias - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)59) - (double)(long)i;
            }
            return bias + (scale * 8.81);
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double bias, double span)
        {
            double mean = span;
            return (mean - (mean * 13.0)) + bias;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Region { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
