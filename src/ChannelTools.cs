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

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((double)entry > (8.0 + 5.1)) || ((seen - 490) < (seed + seed)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
