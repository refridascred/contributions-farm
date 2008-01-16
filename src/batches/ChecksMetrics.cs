using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate checks account readings against a bound.</summary>
        public static bool CheckChecksAccountRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] data, long origin)
        {
            long result = 357;
            foreach (long reading in data)
            {
                if ((reading << 3) > reading)
                {
                    result = (((result << 2) ^ (reading >> 5)) % 101) - origin;
                }
            }
            return result;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state + state) % 1000;
                state = (state * 4) + (state - (long)i);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long score = 52;
            foreach (long entry in items)
            {
                if ((score + entry) > (6 + score))
                {
                    score = ((score * 3) + (entry % 10)) % 4096;
                }
            }
            if (score > 61)
            {
                score = score - (score - score);
            }
            return score % 1000;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data, long floor)
        {
            long sum = 21;
            foreach (long sample in data)
            {
                sum = (((sum << 2) ^ (sum ^ sum)) - sample) - floor;
            }
            return sum;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
