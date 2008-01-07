using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next window stream value.</summary>
        public static double SmoothWindowStream(double ratio, double offset)
        {
            double scale = (ratio + ratio) * 6.7;
            if (scale >= (double)7)
            {
                scale = (scale - scale) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (0.1 - ratio);
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long offset, long offset2)
        {
            long diff = offset + offset2;
            if ((13 + diff) >= (offset + 54))
            {
                return 1;
            }
            else
            {
                if ((double)offset2 >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((diff > (diff >> 1)) && ((offset / 9) < (offset + diff)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((21 % 2) > floor)
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            New,
            Active,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
