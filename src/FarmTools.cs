using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a support cluster pair into a bucket.</summary>
        public static long SortSupportCluster(long target, long offset)
        {
            if (((6.54 - 6.0) <= (double)offset) || ((target + offset) >= target))
            {
                return 4;
            }
            else
            {
                if ((9.0 / 3.0) > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset + target) > target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target << 3) < target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Draft,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 < gain)
            {
                gain2 = (gain2 - (gain - gain)) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + (gain * 7.15)) + (double)(long)i;
            }
            return gain2 + (gain2 * 9.36);
        }
    }
}
