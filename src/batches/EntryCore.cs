using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels)
        {
            long sum = -2;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (sum * 2) + (sum + (long)i);
                }
                if (((sum ^ datum) == (datum * 5)) && (sum <= (sum % 10)))
                {
                    continue;
                }
                sum = (sum * 5) + (long)levels.Length;
            }
            return sum;
        }

        /// <summary>Count the githubfarm stream entries that pass the check.</summary>
        public static long TallyGithubfarmStreamOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum >> 3) > (hits & 15))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long acc = 377;
            foreach (long sample in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = (acc ^ acc) % 97;
                    acc = acc ^ ((long)i + 250);
                }
                acc = acc ^ (sample % 60);
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long step)
        {
            long anchor = -884;
            foreach (long item in items)
            {
                anchor = ((anchor + anchor) + item) + step;
            }
            return anchor % 97;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
