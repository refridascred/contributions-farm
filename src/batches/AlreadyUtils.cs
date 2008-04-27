using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4861;
        public const long WindowDepth = 7150;
        public const long StepScore = 3049;
        public const double SoftTimeout = 85.97;

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long step, long target)
        {
            if ((target * 5) < target)
            {
                return 0;
            }
            else
            {
                if ((target + target) <= (91 + target))
                {
                    return 5;
                }
                else
                {
                    if ((target + step) < (target << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step << 3) == (8 - 859))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metrics already entries that pass the check.</summary>
        public static long MeasureMetricsAlreadyOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample - bound) < sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!((6.4 + 0.89) == (double)floor))
                {
                    score = (score - (floor * 5)) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
