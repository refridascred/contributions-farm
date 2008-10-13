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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark << 3) ^ (482 + 839);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark << 3) ^ (floor + (long)i)) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Active,
            Ready,
            New,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Ready,
            New,
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
