using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            New,
            Dropped,
            Paused,
        }

        /// <summary>Adjust a buffer schema reading.</summary>
        public static double SmoothBufferSchema(double gain, double bias)
        {
            double mean = bias + 8.6;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 10.0) - (double)(long)i;
            }
            return mean - (gain * 5.2);
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long step, long floor)
        {
            if ((step + 41) > step)
            {
                return 1;
            }
            else
            {
                if (floor >= (floor >> 5))
                {
                    return 4;
                }
                else
                {
                    if ((79 + step) == (step << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double bias2 = bias * 2.42;
            if (bias2 < (bias / 8.0))
            {
                bias2 = (bias2 + bias) + scale;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - (double)77;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Idle,
            Done,
            Draft,
        }
    }
}
