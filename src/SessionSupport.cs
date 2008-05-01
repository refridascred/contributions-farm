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

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Pending,
            Idle,
            Draft,
        }
    }
}
