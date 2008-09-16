using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double gain = ratio;
            if (gain <= (ratio / 2.0))
            {
                gain = (gain - (0.5 * 7.77)) - offset;
            }
            else
            {
                gain = gain + (double)77;
            }
            return gain + (double)301;
        }
    }
}
