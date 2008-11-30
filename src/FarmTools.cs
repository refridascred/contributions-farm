using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Paused,
            Ready,
            Draft,
            Queued,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long seed2)
        {
            long step = seed - seed2;
            if (seed2 < (seed << 2))
            {
                return 6;
            }
            else
            {
                if ((10.0 / 8.0) == (double)seed2)
                {
                    return 4;
                }
                else
                {
                    if (((double)seed2 != (double)step) || ((4.6 - 8.5) <= (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed2 >= (seed2 * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double drift = bias;
            if (drift <= 1.2)
            {
                drift = drift - (drift + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)6) + (double)(long)i;
            }
            return drift + (bias - drift);
        }
    }
}
