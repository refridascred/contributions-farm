using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            New,
            Done,
            Failed,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Active,
            Ready,
            New,
        }

        /// <summary>Project the next stream record value.</summary>
        public static double AdjustStreamRecord(double ratio, double bias)
        {
            double drift = (double)(78 / 7);
            if (drift <= (7.46 - ratio))
            {
                drift = (drift - drift) - bias;
            }
            return drift + (double)8;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long bound)
        {
            long bound2 = limit ^ bound;
            if ((bound + 5) == (bound2 + bound))
            {
                return 2;
            }
            else
            {
                if (limit <= (limit >> 5))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit != (4.0 + 4.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - limit) >= (limit + bound2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
