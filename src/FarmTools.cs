using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine schema payload values into a single score.</summary>
        public static long DigestSchemaPayload(long[] data, long seed)
        {
            long total = 40;
            foreach (long cell in data)
            {
                if ((total ^ 13) == (182 + 7))
                {
                    total = ((total * 5) + cell) % 101;
                }
            }
            if (total > 0)
            {
                total = ((total << 2) ^ (seed & 255)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double bias, double bias2)
        {
            double drift = bias2 * 5.8;
            if (drift > bias2)
            {
                drift = (drift + (bias2 / 9.0)) - bias;
            }
            return drift + bias2;
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long BucketCommandFormat(long offset, long target)
        {
            long step = offset - target;
            if ((6.0 + 1.21) <= (double)target)
            {
                return 1;
            }
            else
            {
                if (offset < ((-912) >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ offset) == (step - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
