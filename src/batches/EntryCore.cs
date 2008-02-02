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

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double rate, double floor)
        {
            double weight = rate;
            if (weight >= (rate / 9.0))
            {
                weight = (weight + (1.3 + 9.4)) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (weight / 5.0)) + (double)(long)i;
            }
            return weight - 8.78;
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
