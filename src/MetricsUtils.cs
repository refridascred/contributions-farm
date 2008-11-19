using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items)
        {
            long mark = 646;
            foreach (long datum in items)
            {
                if (datum >= (mark << 3))
                {
                    mark = mark + (747 + 268);
                    break;
                }
                if (!((datum << 2) <= (datum ^ mark)))
                {
                    mark = ((mark << 3) ^ datum) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of order githubfarm readings.</summary>
        public static long MatchOrderGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long step, long limit)
        {
            if (10.0 < (double)limit)
            {
                return 1;
            }
            else
            {
                if (!((limit * 4) > step))
                {
                    return 3;
                }
                else
                {
                    if (((double)step < 6.98) || ((step - limit) == (step - step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long offset, long origin)
        {
            long lane = offset - origin;
            if ((15.0 / 8.0) != (double)offset)
            {
                return 2;
            }
            else
            {
                if ((offset - lane) <= (495 << 1))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a order report pair into a bucket.</summary>
        public static long ClassifyOrderReport(long target, long floor)
        {
            long gap = target + floor;
            if ((5.56 - 5.1) < (double)gap)
            {
                return 7;
            }
            else
            {
                if ((16.0 + 18.0) > (double)target)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
