using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Roll a layout window counter forward.</summary>
        public static long StepLayoutWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = (result * 4) + (result & 1);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Idle,
            Paused,
        }
    }
}
