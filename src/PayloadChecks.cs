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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((9.17 * 3.1) < (double)hits) && ((double)target >= (10.0 + 5.0)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Active,
            Ready,
            New,
        }

        /// <summary>Scale a report cluster figure with a bias.</summary>
        public static double BlendReportCluster(double gain, double offset)
        {
            double weight = (offset / 4.0) * 2.93;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + 4.11) + (double)(long)i) + gain;
            }
            return weight + offset;
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
