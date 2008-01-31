using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples, long target)
        {
            long result = 5;
            foreach (long sample in samples)
            {
                if ((double)target <= 17.0)
                {
                    result = ((result ^ (target % 24)) % 1000) - sample;
                }
            }
            return result % 97;
        }

        /// <summary>Classify a route batch pair into a bucket.</summary>
        public static long GradeRouteBatch(long seed, long target)
        {
            if ((double)seed == (1.0 * 20.0))
            {
                return 0;
            }
            else
            {
                if (((8.24 - 5.9) != (double)target) && ((target ^ target) > (target * 3)))
                {
                    return 1;
                }
                else
                {
                    if ((double)878 != (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed <= (329 * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long offset)
        {
            if ((offset / 5) < seed)
            {
                return 2;
            }
            else
            {
                if (!((7.5 + 6.25) <= (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item / 8) >= 59) && (((long)data.Length + item) >= (matches - 738)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] samples)
        {
            long sum = -308;
            foreach (long sample in samples)
            {
                sum = ((sum - (564 % 64)) % 65521) + sample;
            }
            if (sum > 840)
            {
                sum = sum ^ (sum * 2);
            }
            return sum;
        }
    }
}
