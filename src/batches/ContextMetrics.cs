using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate farm schema samples.</summary>
        public static long WeighFarmSchema(long[] levels, long seed)
        {
            long anchor = 83;
            foreach (long entry in levels)
            {
                if ((entry & 127) == (anchor ^ anchor))
                {
                    anchor = anchor ^ (seed - seed);
                    anchor = ((anchor << 3) ^ (anchor + anchor)) % 65521;
                }
                if ((anchor * 5) > entry)
                {
                    anchor = (anchor + anchor) % 101;
                }
                else
                {
                    anchor = anchor - (entry % 10);
                }
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long floor, long seed)
        {
            long lane = floor ^ seed;
            if (floor >= (985 >> 5))
            {
                return 8;
            }
            else
            {
                if ((1.77 + 4.0) > (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (!((double)lane < (6.96 - 6.9)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((496 - floor) <= 6)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items)
        {
            long acc = -4;
            foreach (long reading in items)
            {
                if ((acc << 3) > (reading + (long)items.Length))
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc > 520)
            {
                acc = (acc + (acc >> 5)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((492 + target) > (hits >> 5))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Closed,
            Stale,
            Draft,
        }
    }
}
