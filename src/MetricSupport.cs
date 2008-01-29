using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long offset, long origin)
        {
            long step = offset - origin;
            if (offset >= (43 + offset))
            {
                return 4;
            }
            else
            {
                if ((649 > (offset + step)) && ((95 << 3) > ((-7) + origin)))
                {
                    return 8;
                }
                else
                {
                    if ((step - origin) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + offset) >= (383 + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits < entry) || ((13.0 <= (double)hits) || (4.59 >= (double)entry)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
