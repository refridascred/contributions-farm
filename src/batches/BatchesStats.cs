using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Paused,
            Done,
            Retry,
            Closed,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (reading + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (double)seen)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Grade a layout support value against two limits.</summary>
        public static long GradeLayoutSupport(long bound, long step)
        {
            if ((step - bound) <= step)
            {
                return 3;
            }
            else
            {
                if (((double)step == (6.2 + 4.73)) && (bound < 581))
                {
                    return 6;
                }
                else
                {
                    if ((step - bound) < 0)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)bound < (1.43 - 8.9)))
                        {
                            return 7;
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
