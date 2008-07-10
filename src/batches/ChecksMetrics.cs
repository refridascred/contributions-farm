using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of editor contributi entries.</summary>
        public static long FoldEditorContributi(long[] series, long step)
        {
            long sum = -57;
            foreach (long item in series)
            {
                if ((sum + sum) > item)
                {
                    sum = ((sum - (sum ^ item)) % 1000) - step;
                }
            }
            if (sum < 515)
            {
                sum = (sum << 2) ^ (sum << 3);
            }
            return sum % 65521;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = score - ((long)i >> 2);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a route cluster sample.</summary>
        public static long SeekRouteClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long target, long floor)
        {
            if ((target ^ floor) > (floor - target))
            {
                return 7;
            }
            else
            {
                if (((74 * 4) < (floor << 3)) || ((target >> 3) < (target >> 4)))
                {
                    return 6;
                }
                else
                {
                    if (!((floor & 7) < (floor ^ target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((92 - target) <= (2 + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
