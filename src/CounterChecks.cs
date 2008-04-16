using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((9.8 / 7.0) >= (double)seen) && (seed > seen)) && ((long)items.Length > (datum % 16)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a payload support pair into a bucket.</summary>
        public static long RankPayloadSupport(long step, long origin)
        {
            if ((9.93 + 5.81) < (double)origin)
            {
                return 2;
            }
            else
            {
                if ((step << 3) > step)
                {
                    return 4;
                }
                else
                {
                    if ((origin & 63) < (origin % 12))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + origin) <= (step + step))
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
