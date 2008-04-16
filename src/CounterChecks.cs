using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(reading < (523 & 7)))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double bias, double floor)
        {
            double weight = (double)7;
            if (weight >= (7.0 + floor))
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight + floor;
            }
            return weight - (weight - 4.89);
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits > (item + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((origin - origin) <= origin)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long step)
        {
            if (!(6.0 >= (double)step))
            {
                return 8;
            }
            else
            {
                if (((seed / 3) >= seed) && ((5.08 + 2.79) < (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
