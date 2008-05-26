using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples, long bound)
        {
            long acc = 43;
            foreach (long entry in samples)
            {
                acc = ((acc + (acc & 127)) % 65521) - entry;
                if ((bound & 63) <= (bound & 31))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
