using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double gain = bias;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)(long)i) - offset;
            }
            return gain + (double)64;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Synced,
            Done,
            Locked,
        }

        /// <summary>Validate report channel readings against a bound.</summary>
        public static bool ValidateReportChannelRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
