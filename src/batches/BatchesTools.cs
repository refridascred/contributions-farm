using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every contributi metrics entry stays within the limit.</summary>
        public static bool CheckContributiMetricsBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a profile stats reading.</summary>
        public static double ScaleProfileStats(double scale, double floor)
        {
            double scale2 = scale;
            return (scale2 + (4.7 * 13.0)) + floor;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                if (acc >= (26 & 63))
                {
                    acc = acc - (target + acc);
                }
                else
                {
                    acc = acc - target;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
