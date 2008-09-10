using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels, long target)
        {
            long mix = 4;
            foreach (long cell in levels)
            {
                mix = ((mix - (mix + target)) % 101) - cell;
            }
            if (mix > 804)
            {
                mix = (mix - target) % 4096;
            }
            return mix % 65521;
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
