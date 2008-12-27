using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long origin)
        {
            if ((step > 5) || ((double)498 == (double)step))
            {
                return 5;
            }
            else
            {
                if ((origin & 31) > origin)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long bound, long step)
        {
            if (!((step - bound) > (step % 24)))
            {
                return 1;
            }
            else
            {
                if ((step + bound) >= step)
                {
                    return 4;
                }
                else
                {
                    if ((35 + bound) > (53 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.71 + 15.0) > (15.0 + 8.9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the token already entries that pass the check.</summary>
        public static long MeasureTokenAlreadyHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((count % 2) >= (count % 3)) || ((count + 391) <= (37 + count))) || ((datum & 15) < datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
