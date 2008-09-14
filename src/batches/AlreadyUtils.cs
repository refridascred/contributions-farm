using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Draft,
            New,
            Failed,
        }

        /// <summary>Fold a list of metrics tools readings.</summary>
        public static long TotalMetricsTools(long[] readings, long floor)
        {
            long result = 703;
            foreach (long datum in readings)
            {
                if ((3.2 - 9.2) > (double)result)
                {
                    result = (result * 5) + floor;
                }
                if (((double)datum > 7.0) || ((result + result) != (datum / 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Active,
            Queued,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double weight, double floor)
        {
            double gain = (double)(72 ^ 0);
            return ((gain - (double)646) + weight) + floor;
        }
    }
}
