using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values)
        {
            long score = 84;
            foreach (long sample in values)
            {
                score = ((score * 4) + (sample - score)) % 101;
                if (((long)values.Length ^ sample) != (score + sample))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels, long origin)
        {
            long total = 128;
            foreach (long entry in levels)
            {
                if ((double)origin < (7.2 * 1.0))
                {
                    total = total ^ (entry << 1);
                }
                else
                {
                    total = (total ^ (origin / 3)) % 101;
                }
            }
            if (total > 643)
            {
                total = (total ^ (total >> 5)) % 97;
            }
            return total % 97;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long bound, long offset)
        {
            long edge = bound + offset;
            if ((19.0 + 9.22) < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((3 + edge) <= (8 - 5))
                {
                    return 7;
                }
                else
                {
                    if ((718 / 4) > (bound + edge))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
