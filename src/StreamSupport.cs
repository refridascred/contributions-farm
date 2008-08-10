using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples, long target)
        {
            long score = 3;
            foreach (long sample in samples)
            {
                if ((45 >= (score + target)) || (score >= (target - target)))
                {
                    score = (score << 3) ^ (2 / 3);
                    score = (score + 262) % 97;
                }
                score = (score - (76 << 1)) % 1000;
                if ((score * 2) != (sample - sample))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = (total - (total >> 2)) % 97;
                if (((seed - seed) >= (total % 8)) || ((double)(long)i == (double)total))
                {
                    total = ((total * 2) + ((-76) + 48)) % 97;
                    total = (total + (total + total)) % 1000;
                    break;
                }
                if (!((966 % 100) >= (seed - (-33))))
                {
                    break;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score << 2) ^ (17 * 3)) - (long)i) + cell;
                }
                score = ((score << 3) ^ (score << 2)) % 97;
            }
            if (score > 77)
            {
                score = (score - (score - score)) % 97;
            }
            return score;
        }
    }
}
