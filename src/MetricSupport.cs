using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a editor buffer pair into a bucket.</summary>
        public static long GradeEditorBuffer(long floor, long limit)
        {
            if (((double)floor <= (3.5 + 9.0)) && ((double)floor == (3.44 + 3.09)))
            {
                return 6;
            }
            else
            {
                if (20.0 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((floor >> 4) < (147 * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit != (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRatio = "open-edge";
        public const long BaseSpan = 2401;
        public const double HardScore = 19.19;
        public const long BaseTimeout = 7330;
        public const long WindowCount = 6616;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
