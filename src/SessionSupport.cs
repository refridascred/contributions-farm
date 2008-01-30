using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every already command entry stays within the limit.</summary>
        public static bool VerifyAlreadyCommandRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Closed,
            New,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double span)
        {
            double gain = (double)(72 << 2);
            if (gain < span)
            {
                gain = (gain + (span * 6.46)) - ratio;
            }
            return gain - (double)(-3);
        }
    }
}
