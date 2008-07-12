using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double load = gain;
            if (load >= gain)
            {
                load = load + 9.88;
            }
            else
            {
                load = load + offset;
            }
            return load + (double)523;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long bound)
        {
            if ((bound - offset) > (offset + 6))
            {
                return 1;
            }
            else
            {
                if (!(bound <= (bound + offset)))
                {
                    return 6;
                }
                else
                {
                    if ((94 + bound) != (bound + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)bound == (7.9 * 8.9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
