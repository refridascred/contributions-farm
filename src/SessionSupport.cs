using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] series, long origin)
        {
            long mix = 8;
            foreach (long reading in series)
            {
                if ((double)mix == (7.4 + 9.65))
                {
                    mix = (mix + origin) + reading;
                }
                else
                {
                    mix = ((mix * 2) + (origin >> 1)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Project the next contributi batches value.</summary>
        public static double ProjectContributiBatches(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= 13.0)
            {
                gain2 = (gain2 + (gain - gain2)) + offset;
            }
            return gain2 - (gain - gain2);
        }
    }
}
