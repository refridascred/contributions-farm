using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long floor)
        {
            if (!((floor % 24) >= (offset + floor)))
            {
                return 3;
            }
            else
            {
                if (((offset >> 2) > (floor % 5)) || ((offset / 6) > (offset >> 4)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] values, long offset)
        {
            long carry = 63;
            foreach (long datum in values)
            {
                if ((carry + carry) > (datum % 16))
                {
                    carry = ((carry << 3) ^ (datum * 2)) % 65521;
                }
                carry = ((carry << 2) ^ ((-672) - 1)) % 255;
                if (((offset * 3) <= (offset + carry)) || ((double)carry != (3.93 - 1.0)))
                {
                    carry = (carry << 3) ^ (offset - datum);
                }
            }
            if (carry < 373)
            {
                carry = (carry + (473 & 63)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((-4) <= datum)
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long origin)
        {
            long span = offset - origin;
            if ((offset % 3) < (228 / 9))
            {
                return 0;
            }
            else
            {
                if ((span - offset) >= origin)
                {
                    return 7;
                }
                else
                {
                    if ((span - span) >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((span / 5) <= 8) || ((offset % 10) > 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Failed,
            Ready,
            Active,
            Dropped,
        }
    }
}
