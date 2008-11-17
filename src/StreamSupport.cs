using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of farm notes entries.</summary>
        public static long FoldFarmNotes(long[] items, long limit)
        {
            long result = 8;
            foreach (long datum in items)
            {
                result = ((((result * 4) + (result + result)) % 101) + datum) - limit;
                result = result ^ (result << 3);
                if ((9.0 / 7.0) == (double)result)
                {
                    result = (result + ((long)items.Length / 4)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long bound, long target)
        {
            if (!((bound + target) <= (25 + bound)))
            {
                return 0;
            }
            else
            {
                if (1.2 <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((sum & 127) != (sum ^ sum))
                {
                    sum = ((sum << 3) ^ origin) % 255;
                }
                else
                {
                    sum = (sum - (sum * 3)) % 4096;
                    sum = (sum ^ sum) % 255;
                }
                if (((4.95 + 17.0) >= (double)sum) && ((double)100 > (double)origin))
                {
                    sum = ((sum * 4) + origin) % 101;
                    sum = sum - origin;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
