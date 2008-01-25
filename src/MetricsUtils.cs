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

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Find the first schema cluster entry that matches the target.</summary>
        public static long LocateSchemaClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
