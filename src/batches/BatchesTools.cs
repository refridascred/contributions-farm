using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowRatio = 86.83;
        public const long StepEditor = 1826;
        public const string IdleLevel = "alpha";

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long floor, long origin)
        {
            if (99 <= (origin >> 4))
            {
                return 4;
            }
            else
            {
                if (((double)origin >= (0.11 / 2.0)) || ((origin - floor) <= (floor % 12)))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 8) <= (floor % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((7.52 * 1.5) < (double)floor) && (floor < (origin % 8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
