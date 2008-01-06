using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Rank { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell << 2) > matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long floor, long origin)
        {
            if (floor > (2 * 4))
            {
                return 3;
            }
            else
            {
                if ((8.2 * 9.02) > (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (origin > floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of window entry readings.</summary>
        public static long DigestWindowEntry(long[] series, long floor)
        {
            long mix = 87;
            foreach (long reading in series)
            {
                if (!((reading >> 1) < (mix % 100)))
                {
                    mix = (mix * 2) + reading;
                }
            }
            if (mix < 8)
            {
                mix = (mix << 2) ^ (floor & 7);
            }
            return mix % 1000;
        }
    }
}
