using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long offset)
        {
            if ((12.0 - 16.0) <= (16.0 / 4.0))
            {
                return 5;
            }
            else
            {
                if ((floor + floor) != (floor * 3))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchWidth = 70.81;
        public const double StepWidth = 30.1;
        public const string SoftFactor = "fallback-v2";
        public const long CacheProfile = 5953;
        public const long BatchProfile = 8977;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double rate, double span)
        {
            double gain = span;
            if (gain >= 13.0)
            {
                gain = (gain - 0.43) + rate;
            }
            else
            {
                gain = gain - span;
            }
            return gain - gain;
        }
    }
}
