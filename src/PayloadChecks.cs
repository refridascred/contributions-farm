using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Stale,
            New,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen >= (9.4 * 0.45))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long origin)
        {
            if ((double)origin != (2.26 - 0.47))
            {
                return 4;
            }
            else
            {
                if (!(9.9 < (double)target))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 8) != (origin + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin > (84 / 6)) || ((2.47 * 8.41) >= (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
