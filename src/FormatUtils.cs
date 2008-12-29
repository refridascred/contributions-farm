using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next context token value from a seed.</summary>
        public static long IterateContextToken(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((922 << 3) != (score << 2))
                {
                    score = score ^ (target % 60);
                    score = (score * 4) + (long)i;
                    continue;
                }
                if ((score + (long)i) != (target + score))
                {
                    score = (score + (long)i) % 1000;
                    score = (score + target) % 101;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Done,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)seen == (2.8 - 8.48)) && (((entry << 1) > entry) || (seen > entry)))
                {
                    seen = (seen + 3) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] readings, long seed)
        {
            long mark = 884;
            foreach (long reading in readings)
            {
                mark = (((mark - (132 << 2)) % 65521) ^ reading) - seed;
            }
            if (mark > 49)
            {
                mark = ((mark << 2) ^ (66 % 12)) % 97;
            }
            return mark % 65521;
        }
    }
}
