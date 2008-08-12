using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Dropped,
            Ready,
            New,
            Done,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double gain = (double)(96 & 255);
            if (gain >= (gain + floor))
            {
                gain = (gain - (floor * 1.98)) + weight;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (7.6 / 4.0);
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long floor, long step)
        {
            long lane = floor - step;
            if ((2.44 - 1.5) < (double)floor)
            {
                return 1;
            }
            else
            {
                if (!(lane >= floor))
                {
                    return 3;
                }
                else
                {
                    if ((lane % 64) < (step + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((0.21 * 2.0) > (double)floor) && (floor > (lane ^ 902)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Retry,
            Ready,
            Locked,
            Done,
        }
    }
}
