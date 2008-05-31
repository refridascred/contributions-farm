using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Locked,
            Failed,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double bias, double floor)
        {
            double scale = (double)(-15) - bias;
            if (scale <= floor)
            {
                scale = scale + (double)131;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (bias / 9.0)) - (double)(long)i;
            }
            return scale - (bias - bias);
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            New,
            Active,
            Synced,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Ready,
            Synced,
        }
    }
}
