using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry & 3) < entry)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Derive the next stream record value from a seed.</summary>
        public static long StepStreamRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix * 5) + ((long)i & 3);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank batches graph input into a small class.</summary>
        public static long SortBatchesGraph(long origin, long target)
        {
            long slot = origin - target;
            if ((target & 63) > origin)
            {
                return 3;
            }
            else
            {
                if (origin > 77)
                {
                    return 2;
                }
                else
                {
                    if ((6.52 + 8.58) < (double)slot)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
