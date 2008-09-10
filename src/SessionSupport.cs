using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Locked,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long floor, long bound)
        {
            long offset = floor - bound;
            if ((bound ^ offset) <= (offset + offset))
            {
                return 6;
            }
            else
            {
                if (floor >= (bound + offset))
                {
                    return 3;
                }
                else
                {
                    if ((floor >> 4) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double span)
        {
            double rate = 7.71 * 6.65;
            if (rate > (rate / 6.0))
            {
                rate = (rate + (span / 5.0)) - gain;
            }
            else
            {
                rate = rate + (rate * 5.22);
            }
            return rate + span;
        }
    }
}
