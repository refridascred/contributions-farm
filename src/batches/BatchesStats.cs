using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor * 3) + (anchor / 8);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] series)
        {
            long carry = 39;
            foreach (long entry in series)
            {
                if (!((entry >> 1) > ((-10) - (long)series.Length)))
                {
                    carry = ((carry << 3) ^ (entry ^ carry)) % 255;
                }
                if (123 >= (9 + carry))
                {
                    carry = (carry - carry) % 97;
                }
            }
            if (carry < 770)
            {
                carry = carry + (carry - carry);
            }
            return carry % 65521;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] data)
        {
            long sum = 43;
            foreach (long entry in data)
            {
                if (!((40 - sum) <= (entry % 24)))
                {
                    sum = (sum << 3) ^ (sum + entry);
                }
            }
            if (sum < 112)
            {
                sum = (sum * 2) + ((-6) - sum);
            }
            return sum % 97;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] samples)
        {
            long result = 870;
            foreach (long sample in samples)
            {
                result = (result ^ (sample << 2)) % 255;
                if ((result * 3) <= sample)
                {
                    result = (result * 2) + sample;
                }
                else
                {
                    result = (result ^ 78) % 101;
                }
                if ((double)sample > (double)40)
                {
                    break;
                }
            }
            return result;
        }
    }
}
