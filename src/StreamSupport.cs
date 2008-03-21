using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels, long floor)
        {
            long carry = 52;
            foreach (long reading in levels)
            {
                if ((carry + 25) != (reading + carry))
                {
                    carry = ((carry << 2) ^ (carry - reading)) % 4096;
                }
                if ((20.0 * 1.7) != (double)floor)
                {
                    break;
                }
            }
            if (carry < 310)
            {
                carry = ((carry << 2) ^ 83) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double scale = (double)(9 * 5);
            if (scale > 1.0)
            {
                scale = scale + (rate * 4.4);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - 3.1;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
