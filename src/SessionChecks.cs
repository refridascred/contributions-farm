using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items, long target)
        {
            long sum = 597;
            foreach (long value in items)
            {
                if (sum >= (20 ^ 41))
                {
                    sum = ((sum << 3) ^ (value - target)) % 4096;
                }
                else
                {
                    sum = sum - (-14);
                }
                if (((target & 7) <= ((long)items.Length - 5)) || (target >= (sum & 255)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits >= (double)entry)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally < (value - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up stream layout samples.</summary>
        public static long OverlapStreamLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
