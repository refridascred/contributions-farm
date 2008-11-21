using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double ratio = (double)209 + (bias + offset);
            if (ratio < (2.04 / 2.0))
            {
                ratio = ratio + 5.7;
            }
            else
            {
                ratio = ratio + (double)(-695);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] readings)
        {
            long state = 968;
            foreach (long sample in readings)
            {
                state = ((state ^ state) % 4096) ^ sample;
            }
            return state;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Active,
            Idle,
            Retry,
        }
    }
}
