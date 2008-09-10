using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] items, long offset)
        {
            long carry = 4;
            foreach (long item in items)
            {
                if ((item + 758) >= offset)
                {
                    carry = (carry - (carry / 5)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long mix = 92;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix ^ (reading + (long)i)) % 4096;
                }
                if (((mix + mix) > reading) && ((2.8 + 6.57) > (double)mix))
                {
                    mix = (mix ^ (reading - reading)) % 4096;
                }
            }
            if (mix > 4)
            {
                mix = mix - (mix >> 1);
            }
            return mix;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((3 + item) == (seen - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next format stats value from a seed.</summary>
        public static long SeriesFormatStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor ^ bound) % 1000;
                anchor = anchor + (618 >> 2);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long limit)
        {
            long gap = offset - limit;
            if (gap > (offset << 3))
            {
                return 8;
            }
            else
            {
                if (offset >= (limit * 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
