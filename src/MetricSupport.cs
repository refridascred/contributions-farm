using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long offset)
        {
            if ((double)offset >= (7.0 * 8.87))
            {
                return 7;
            }
            else
            {
                if ((offset % 2) <= offset)
                {
                    return 4;
                }
                else
                {
                    if ((double)offset >= 8.9)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 60) != (limit ^ 421))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
