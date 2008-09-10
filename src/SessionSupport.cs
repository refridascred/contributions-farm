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

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double scale = (weight / 3.0) - floor;
            if (scale >= 18.0)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + scale;
        }
    }
}
