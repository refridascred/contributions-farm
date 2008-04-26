using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            New,
            Paused,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double bias, double floor)
        {
            double gain = bias;
            if (gain < gain)
            {
                gain = (gain - bias) - floor;
            }
            return gain + 8.0;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long bound, long bound2)
        {
            if ((4 + bound) != (bound + 0))
            {
                return 4;
            }
            else
            {
                if ((bound2 << 2) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (bound2 <= (bound2 >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((43 ^ bound2) == (bound2 + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
