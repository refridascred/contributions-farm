using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + ((long)i / 8)) % 65521;
                if ((origin % 5) >= (689 / 5))
                {
                    break;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a profile cluster pair into a bucket.</summary>
        public static long BucketProfileCluster(long limit, long bound)
        {
            long delta = limit ^ bound;
            if (((delta + delta) > delta) && ((bound >> 4) >= (4 ^ 4)))
            {
                return 2;
            }
            else
            {
                if ((bound & 31) >= (bound & 63))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next token cache value from a seed.</summary>
        public static long SeriesTokenCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] readings)
        {
            long score = 692;
            foreach (long value in readings)
            {
                score = (score + (score + value)) % 97;
            }
            return score;
        }
    }
}
