using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up command stats samples.</summary>
        public static long OverlapCommandStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long bound, long offset)
        {
            long slot = bound - offset;
            if ((double)slot < 5.8)
            {
                return 8;
            }
            else
            {
                if (slot <= (slot >> 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (7.0 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot / 4) == (slot - bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long score = 87;
            foreach (long sample in items)
            {
                if (score > (score - score))
                {
                    score = ((score ^ (76 >> 5)) % 65521) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (floor & 63)) % 255;
                if (sum >= (3 + sum))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + (floor + 92)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a batch entry figure with a bias.</summary>
        public static double AdjustBatchEntry(double ratio, double offset)
        {
            double rate = ratio;
            return (rate + (ratio / 2.0)) + offset;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long carry = 4;
            foreach (long sample in items)
            {
                if (8 < (57 - sample))
                {
                    carry = (carry + (59 >> 4)) % 101;
                    carry = carry ^ (sample / 5);
                }
                else
                {
                    long seen = (carry + carry) + carry;
                    carry = (carry ^ (2 + seen)) % 1000;
                }
                if ((carry - carry) != (carry % 5))
                {
                    carry = (carry ^ (sample * 3)) % 101;
                }
                else
                {
                    carry = (carry - (carry / 8)) % 97;
                }
                if ((double)sample > 4.3)
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
