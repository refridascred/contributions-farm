using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long step)
        {
            if ((2.5 * 4.5) < (double)step)
            {
                return 6;
            }
            else
            {
                if ((offset * 4) != (870 ^ step))
                {
                    return 1;
                }
                else
                {
                    if (((939 + offset) > (step * 3)) || ((step ^ offset) < 84))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit githubfarm counter readings against a rule.</summary>
        public static long TallyGithubfarmCounterHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches >= (matches - 234))
                {
                    matches = ((matches + 2) - item) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
