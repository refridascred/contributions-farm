using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double scale, double offset)
        {
            double scale2 = 3.97;
            if (scale2 >= offset)
            {
                scale2 = (scale2 - offset) - scale;
            }
            else
            {
                scale2 = scale2 + (offset * 17.0);
            }
            return scale2 - (double)150;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!((limit / 4) != (mark + (long)i)))
                {
                    mark = (mark * 3) + (mark + (-9));
                }
                else
                {
                    mark = ((mark << 3) ^ (limit / 3)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
