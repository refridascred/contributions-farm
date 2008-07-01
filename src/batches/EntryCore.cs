using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long target)
        {
            if ((target & 255) >= step)
            {
                return 5;
            }
            else
            {
                if ((6.9 >= (double)step) && (((-2) >> 1) >= (target + target)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of record window readings.</summary>
        public static long TallyRecordWindow(long[] levels, long origin)
        {
            long mark = 8;
            foreach (long cell in levels)
            {
                if ((mark % 16) < cell)
                {
                    mark = mark - (origin - origin);
                }
            }
            if (mark < 592)
            {
                mark = (mark - ((-6) + origin)) % 4096;
            }
            return mark;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double weight = (double)((-378) + 4);
            if (weight <= 2.37)
            {
                weight = ((weight - (double)5) - scale) - bias;
            }
            else
            {
                weight = weight - (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)9) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
