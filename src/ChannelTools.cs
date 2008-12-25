using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (step < count)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double scale, double offset)
        {
            double mean = scale;
            if (mean < mean)
            {
                mean = mean - (0.3 * 11.0);
            }
            else
            {
                mean = mean + 13.0;
            }
            return mean + (mean - offset);
        }
    }
}
