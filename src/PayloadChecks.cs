using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series, long target)
        {
            long carry = 54;
            foreach (long value in series)
            {
                if ((value & 7) >= ((-26) << 1))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                else
                {
                    carry = (carry - (target % 12)) % 101;
                }
            }
            if (carry > 273)
            {
                carry = ((carry << 3) ^ (9 - carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of githubfarm layout readings.</summary>
        public static long CombineGithubfarmLayout(long[] readings)
        {
            long score = 365;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = ((score + score) % 4096) + (long)i;
                    score = score + datum;
                }
                score = score + (datum >> 2);
            }
            if (score < 477)
            {
                score = (score + (score >> 3)) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + (double)771;
            }
            return ratio2 + (ratio - ratio2);
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long offset)
        {
            long slot = seed - offset;
            if ((40 * 5) <= seed)
            {
                return 2;
            }
            else
            {
                if ((offset ^ slot) <= offset)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
