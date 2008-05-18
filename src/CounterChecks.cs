using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long offset, long origin)
        {
            long diff = offset - origin;
            if (((-58) - offset) >= (origin - 90))
            {
                return 2;
            }
            else
            {
                if (origin >= (diff & 15))
                {
                    return 8;
                }
                else
                {
                    if (8.2 <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long offset, long target)
        {
            if ((offset <= (3 * 3)) && ((offset & 63) != (target + target)))
            {
                return 7;
            }
            else
            {
                if (385 < offset)
                {
                    return 8;
                }
                else
                {
                    if ((7.64 / 8.0) > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + 0) == (offset ^ target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((bound << 1) < datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next already profile value from a seed.</summary>
        public static long RollAlreadyProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                score = (score << 2) ^ (score + origin);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
