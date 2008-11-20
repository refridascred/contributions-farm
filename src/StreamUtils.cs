using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long limit, long bound)
        {
            if (((bound + bound) <= (limit ^ limit)) && (limit >= (limit ^ bound)))
            {
                return 1;
            }
            else
            {
                if ((bound << 3) >= (limit ^ bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ limit) >= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((114 / 4) <= (bound - limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double ratio = (double)(88 + 443);
            return ((ratio - (ratio / 8.0)) + weight) + offset;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long limit, long offset)
        {
            long delta = limit - offset;
            if ((limit << 1) < limit)
            {
                return 8;
            }
            else
            {
                if (((limit + offset) >= offset) || ((212 + offset) < offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)235 == (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((delta + limit) >= offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Pending,
            Done,
        }
    }
}
