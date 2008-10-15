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

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 3507;
        public const long IdleDepth = 7853;
        public const long SoftBatches = 2085;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
