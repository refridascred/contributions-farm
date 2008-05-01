using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((1.79 / 8.0) < (double)target)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next layout notes value from a seed.</summary>
        public static long StepLayoutNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((offset / 2) > (mark % 3))
                {
                    break;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                if (748 >= offset)
                {
                    mark = (mark * 5) + (57 & 127);
                    continue;
                }
                else
                {
                    mark = (mark + (offset * 4)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long floor, long origin)
        {
            long delta = floor ^ origin;
            if (!(floor >= (delta ^ origin)))
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (17.0 / 9.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
