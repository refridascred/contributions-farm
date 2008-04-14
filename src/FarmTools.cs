using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long step)
        {
            if ((step - step) <= (step << 3))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (limit << 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double gain2 = (gain * 8.1) * 7.0;
            for (int i = 0; i < 8; i++)
            {
                gain2 = ((gain2 - (gain2 * 5.1)) + (double)(long)i) - offset;
            }
            return gain2 + gain;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                anchor = (anchor - (cell + cell)) % 4096;
                if ((double)cell >= (8.0 * 4.3))
                {
                    anchor = anchor - cell;
                    anchor = (anchor << 2) ^ (anchor + anchor);
                }
                else
                {
                    anchor = (anchor ^ anchor) % 97;
                    anchor = anchor + (anchor >> 4);
                }
                if ((cell / 4) >= (cell / 8))
                {
                    anchor = (anchor - (anchor << 3)) % 101;
                }
                else
                {
                    anchor = (anchor << 2) ^ (cell % 8);
                }
            }
            return anchor % 65521;
        }
    }
}
