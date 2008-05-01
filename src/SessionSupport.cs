using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of stream schema entries.</summary>
        public static long DigestStreamSchema(long[] readings, long seed)
        {
            long mix = -3;
            foreach (long reading in readings)
            {
                if ((162 < (mix & 127)) && ((mix << 2) < (reading - mix)))
                {
                    mix = (mix - seed) % 4096;
                }
                else
                {
                    mix = ((mix * 5) + seed) % 97;
                }
            }
            return mix;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long offset, long limit)
        {
            if (((limit % 2) > (offset & 7)) && ((limit + offset) <= 0))
            {
                return 0;
            }
            else
            {
                if (122 < (offset + offset))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long floor, long floor2)
        {
            if ((double)floor < (7.3 - 9.0))
            {
                return 0;
            }
            else
            {
                if ((floor - 93) != (floor / 7))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
