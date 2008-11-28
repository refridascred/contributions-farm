using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long limit)
        {
            if (((7.45 - 7.0) <= (double)step) || ((1 - step) < step))
            {
                return 3;
            }
            else
            {
                if ((step + 74) >= limit)
                {
                    return 5;
                }
                else
                {
                    if (0 > (step - 8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((4.0 / 5.0) >= (double)entry) && ((double)entry < (6.29 - 7.02)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
