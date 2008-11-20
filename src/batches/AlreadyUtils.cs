using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items)
        {
            long acc = 3;
            foreach (long reading in items)
            {
                acc = acc + (acc - acc);
                acc = (acc * 2) + reading;
                if ((reading + acc) > (acc & 31))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell << 3) != (cell + count))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] levels)
        {
            long result = 837;
            foreach (long sample in levels)
            {
                result = (((result * 3) + (result / 2)) % 4096) - sample;
            }
            if (result > (-4))
            {
                result = (result + result) % 4096;
            }
            return result;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] values)
        {
            long total = -555;
            foreach (long entry in values)
            {
                if ((391 * 2) == (entry << 2))
                {
                    total = (total + (entry << 3)) % 101;
                }
                else
                {
                    total = (total << 2) ^ (total % 100);
                    total = ((total * 3) + (entry ^ total)) % 255;
                }
                if (total > (entry ^ total))
                {
                    total = ((total << 2) ^ (total ^ total)) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long step)
        {
            if ((6 % 60) > (limit >> 5))
            {
                return 7;
            }
            else
            {
                if (!(2.9 > (double)step))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
