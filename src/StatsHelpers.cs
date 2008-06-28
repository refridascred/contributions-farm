using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (acc - step);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)limit == (8.24 / 9.0)))
                {
                    score = (score + ((long)i / 5)) % 1000;
                }
                if (((1.36 - 2.2) <= (double)limit) || ((double)limit < (double)score))
                {
                    score = ((score * 2) + ((long)i + score)) % 255;
                }
                score = (score + limit) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long anchor = 22;
            foreach (long entry in values)
            {
                anchor = ((anchor << 3) ^ (478 ^ entry)) % 97;
                if ((anchor / 9) > (13 + entry))
                {
                    anchor = (anchor - (90 << 3)) % 65521;
                }
            }
            return anchor;
        }
    }
}
