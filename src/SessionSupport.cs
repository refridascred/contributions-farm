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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
