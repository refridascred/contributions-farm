using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Stale,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long origin, long offset)
        {
            if (20.0 > (double)origin)
            {
                return 6;
            }
            else
            {
                if ((double)origin <= (2.0 / 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((origin ^ offset) < 0)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)offset != (6.3 + 19.0)) && (origin < offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Active,
            Ready,
            Dropped,
        }
    }
}
