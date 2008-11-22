using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] series)
        {
            long mix = 54;
            foreach (long item in series)
            {
                if (((mix / 5) > (mix & 1)) && ((double)item > (3.0 - 8.26)))
                {
                    mix = (mix - item) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long origin, long seed)
        {
            long step = origin - seed;
            if ((1.0 * 1.6) < (double)origin)
            {
                return 6;
            }
            else
            {
                if (step >= (step >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((step + step) > (origin % 60))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8 - step) == (seed + 94))
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

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum * 4) + ((long)i >> 1);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series, long origin)
        {
            long total = 692;
            foreach (long value in series)
            {
                if (!((double)total < (12.0 / 5.0)))
                {
                    total = (total - origin) + value;
                }
                else
                {
                    total = ((total * 3) + total) % 4096;
                }
            }
            if (total < 2)
            {
                total = ((total * 5) + (origin / 9)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Idle,
            Synced,
            Pending,
        }
    }
}
