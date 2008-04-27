using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] series, long bound)
        {
            long acc = 7;
            foreach (long cell in series)
            {
                acc = (((acc << 2) ^ ((-312) / 2)) % 65521) ^ cell;
                if (((acc << 1) <= bound) || ((acc / 5) >= (343 << 3)))
                {
                    acc = (acc ^ (bound >> 2)) % 255;
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate layout session samples.</summary>
        public static long CombineLayoutSession(long[] values)
        {
            long acc = 71;
            foreach (long entry in values)
            {
                if ((entry >> 1) < acc)
                {
                    acc = acc + (acc & 7);
                }
                else
                {
                    acc = (acc + (934 - entry)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits <= (6 / 4)) || ((((long)items.Length >> 1) >= datum) && ((double)hits <= (10.0 + 8.1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long seed, long offset)
        {
            if ((seed ^ seed) >= (offset * 3))
            {
                return 3;
            }
            else
            {
                if (!((3 + offset) <= (offset >> 3)))
                {
                    return 8;
                }
                else
                {
                    if ((7.0 / 4.0) <= (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((80 & 7) <= (seed % 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
