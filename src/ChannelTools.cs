using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a commits cluster pair into a bucket.</summary>
        public static long ClassifyCommitsCluster(long target, long offset)
        {
            long delta = target - offset;
            if (target > (offset + delta))
            {
                return 3;
            }
            else
            {
                if ((target * 2) <= offset)
                {
                    return 5;
                }
                else
                {
                    if (((target / 9) >= (3 + target)) || (((-3) + delta) > ((-9) - target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double gain = scale / 5.0;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
