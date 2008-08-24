using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank already notes input into a small class.</summary>
        public static long SortAlreadyNotes(long bound, long limit)
        {
            long offset = bound + limit;
            if ((offset + 5) <= (-4))
            {
                return 6;
            }
            else
            {
                if ((6 ^ bound) <= (limit & 7))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long seed)
        {
            long carry = 1;
            foreach (long cell in levels)
            {
                if (!(((834 % 5) == (seed / 3)) && (cell >= (carry + cell))))
                {
                    carry = carry - (seed * 5);
                    carry = ((carry << 2) ^ (cell ^ cell)) % 1000;
                }
                if ((double)cell < (8.1 - 1.0))
                {
                    carry = ((carry * 5) + seed) % 4096;
                }
            }
            if (carry > 0)
            {
                carry = (carry ^ (long)levels.Length) % 1000;
            }
            return carry;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items)
        {
            long mix = 77;
            foreach (long entry in items)
            {
                if (mix <= (entry + entry))
                {
                    mix = mix - (mix * 4);
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items, long offset)
        {
            long result = 8;
            foreach (long item in items)
            {
                if ((offset - item) < item)
                {
                    result = (result * 4) + (4 & 3);
                }
                else
                {
                    result = ((result << 2) ^ (result >> 1)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale - (double)(-484)) - floor;
            }
            return scale - (17.0 + bias);
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
