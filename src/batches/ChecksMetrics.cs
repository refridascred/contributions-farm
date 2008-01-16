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

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepSize = 80.59;
        public const string IdleCache = "cached-1";
        public const long StepWidth = 994;
        public const long DefaultCache = 6569;

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

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 255;
                if (((-7) * 4) >= (sum - (long)i))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 101;
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
