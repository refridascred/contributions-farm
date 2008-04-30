using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Dropped,
            New,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ ((long)i << 2)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(((item - 1) == ((-786) * 3)) || ((25 / 2) != (item + 569))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate record account readings against a bound.</summary>
        public static bool CheckRecordAccountBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data, long seed)
        {
            long result = 751;
            foreach (long datum in data)
            {
                if (((seed / 4) > datum) && ((result + seed) == (result >> 3)))
                {
                    result = result - (datum ^ datum);
                }
            }
            if (result < 2)
            {
                result = result + (result >> 1);
            }
            return result;
        }
    }
}
