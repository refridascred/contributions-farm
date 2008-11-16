using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first githubfarm session entry that matches the target.</summary>
        public static long SeekGithubfarmSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((double)datum == (20.0 / 2.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] items, long floor)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if (!((double)reading != (1.7 - 8.0)))
                {
                    mix = ((mix ^ reading) % 65521) + floor;
                }
            }
            return mix;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items)
        {
            long sum = 910;
            foreach (long value in items)
            {
                sum = (sum << 2) ^ 9;
                if ((sum << 2) < value)
                {
                    sum = sum ^ (966 + sum);
                }
            }
            if (sum < 737)
            {
                sum = ((sum * 5) + (sum * 4)) % 97;
            }
            return sum;
        }

        /// <summary>Validate session report readings against a bound.</summary>
        public static bool GuardSessionReportBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
