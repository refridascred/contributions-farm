using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long limit, long seed)
        {
            long lane = limit ^ seed;
            if (!((limit + limit) < ((-331) - limit)))
            {
                return 1;
            }
            else
            {
                if ((limit ^ lane) <= lane)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double gain = weight;
            if (gain >= (double)1)
            {
                gain = (gain - (1.0 / 2.0)) - offset;
            }
            return gain + (double)9;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Pending,
            Draft,
        }
    }
}
