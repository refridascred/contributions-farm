using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double scale, double span)
        {
            double load = 2.0;
            if (load < (1.0 + scale))
            {
                load = load - 4.0;
            }
            else
            {
                load = load - (load + span);
            }
            return load + (load - load);
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long step)
        {
            long lane = bound + step;
            if (((double)1 < (double)step) || ((bound ^ bound) < (bound - 1)))
            {
                return 1;
            }
            else
            {
                if ((lane / 6) >= (step >> 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate stats already samples.</summary>
        public static long DigestStatsAlready(long[] values)
        {
            long total = 35;
            foreach (long item in values)
            {
                if (104 >= (6 - item))
                {
                    total = total ^ (97 - item);
                }
            }
            if (total > 91)
            {
                total = total - (total / 3);
            }
            return total;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
