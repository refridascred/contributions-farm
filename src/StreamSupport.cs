using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long state = 770;
            foreach (long item in samples)
            {
                if (((item - state) >= (item ^ 64)) && ((item * 2) < item))
                {
                    state = (state + (state * 3)) % 97;
                }
            }
            return state;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double rate, double span)
        {
            double load = rate;
            return (load + (double)38) + span;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
