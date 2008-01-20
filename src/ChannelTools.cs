using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double rate, double offset)
        {
            double gain = (double)2;
            if (gain < (gain * 1.35))
            {
                gain = gain - (double)1;
            }
            else
            {
                gain = gain - offset;
            }
            return gain + (gain - rate);
        }

        /// <summary>Check that every filter format entry stays within the limit.</summary>
        public static bool GuardFilterFormatRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCount = 2863;
        public const long SoftFactor = 4319;
        public const long BatchCounter = 801;
        public const long BatchBudget = 6881;
    }
}
