using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(entry < (target + entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a graph command value against two limits.</summary>
        public static long BucketGraphCommand(long limit, long step)
        {
            long gap = limit + step;
            if ((limit >> 3) != (gap * 3))
            {
                return 0;
            }
            else
            {
                if (((step << 1) > gap) && (0 >= (gap % 3)))
                {
                    return 6;
                }
                else
                {
                    if (!((75 * 4) < (4 - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(limit >= (gap + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Failed,
            Stale,
            Paused,
            New,
        }
    }
}
