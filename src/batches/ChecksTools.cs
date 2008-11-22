using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long offset, long seed)
        {
            long bound = offset - seed;
            if (((offset >> 2) == (offset * 2)) || ((seed + seed) < (bound & 127)))
            {
                return 8;
            }
            else
            {
                if (((offset - seed) != (seed ^ seed)) && ((offset - seed) > seed))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double gain2 = 12.0;
            if (gain2 < gain2)
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain) - (double)(long)i;
            }
            return gain2 + (bias + gain2);
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double ratio = (bias - bias2) * 20.0;
            if (ratio >= bias2)
            {
                ratio = ratio + (double)777;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)285) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
