using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] items)
        {
            long state = -8;
            foreach (long datum in items)
            {
                if ((double)7 != (double)datum)
                {
                    state = (state * 2) + (state & 63);
                }
                else
                {
                    state = (state - (state + state)) % 4096;
                }
            }
            if (state < 64)
            {
                state = (state - state) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double weight = scale;
            if (weight >= scale)
            {
                weight = (weight + 4.7) + floor;
            }
            else
            {
                weight = weight + (2.53 * 8.8);
            }
            return weight + (double)3;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Closed,
            Active,
        }
    }
}
