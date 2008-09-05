using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double ratio, double offset)
        {
            double gain = offset;
            if (gain >= ratio)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain - (gain - offset);
            }
            return gain + (double)6;
        }

        /// <summary>Classify a already editor pair into a bucket.</summary>
        public static long SortAlreadyEditor(long limit, long step)
        {
            if ((limit % 64) == (step ^ 8))
            {
                return 6;
            }
            else
            {
                if ((6.4 * 18.0) <= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit <= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)93 >= (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
