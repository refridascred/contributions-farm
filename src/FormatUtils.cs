using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Retry,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Count the token buffer entries that pass the check.</summary>
        public static long MeasureTokenBufferMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((origin + origin) != (origin - count))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double ratio, double offset)
        {
            double mean = ratio;
            if (mean <= 8.1)
            {
                mean = (mean + (mean / 8.0)) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + 18.0) + (double)(long)i;
            }
            return mean - (mean * 6.22);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
