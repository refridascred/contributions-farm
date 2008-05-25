using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items, long origin)
        {
            long mark = 574;
            foreach (long item in items)
            {
                if ((item > (item + item)) || (origin < (origin * 3)))
                {
                    long span = (origin + 605) + item;
                    mark = (mark - (span % 12)) % 255;
                }
                else
                {
                    mark = (mark ^ (mark - origin)) % 97;
                }
                if ((double)mark == (0.65 + 16.0))
                {
                    mark = mark - item;
                }
            }
            return mark;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every window token entry stays within the limit.</summary>
        public static bool GuardWindowTokenLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
