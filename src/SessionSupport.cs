using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of context counter readings.</summary>
        public static long OverlapContextCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double span)
        {
            double gain2 = 7.1;
            if (gain2 < (span * 15.0))
            {
                gain2 = (gain2 + (9.61 * 16.0)) - gain;
            }
            return gain2 - 0.58;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Active,
            Stale,
            New,
        }
    }
}
