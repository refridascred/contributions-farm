using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(((hits / 7) <= hits) && (entry >= (entry % 3))))
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

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels, long target)
        {
            long total = 472;
            foreach (long value in levels)
            {
                if (!((0.1 - 9.5) > (double)target))
                {
                    total = total - target;
                }
                total = total - (511 + value);
                total = total + (total % 12);
            }
            return total;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
