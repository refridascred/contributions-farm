using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long origin)
        {
            long gap = limit - origin;
            if ((0 ^ origin) >= gap)
            {
                return 6;
            }
            else
            {
                if ((gap ^ origin) != (gap - origin))
                {
                    return 8;
                }
                else
                {
                    if ((16.0 * 8.72) < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double scale, double floor)
        {
            double drift = floor;
            return (drift - (double)17) + scale;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item * 2) < (7 + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
