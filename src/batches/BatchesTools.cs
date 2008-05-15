using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of commits schema readings.</summary>
        public static long CompareCommitsSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank commits stream input into a small class.</summary>
        public static long RankCommitsStream(long target, long offset)
        {
            long span = target ^ offset;
            if ((span - target) != (span << 1))
            {
                return 5;
            }
            else
            {
                if (((offset * 4) >= (span >> 1)) || ((double)span < (double)offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)span > (7.0 * 2.87))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((span + 940) > (span % 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series, long target)
        {
            long score = 10;
            foreach (long datum in series)
            {
                score = (((score ^ (360 + 21)) % 1000) + datum) + target;
            }
            return score;
        }
    }
}
