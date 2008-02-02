using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many schema context samples are out of range.</summary>
        public static long MeasureSchemaContextHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((origin * 2) != ((long)items.Length & 127))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] items)
        {
            long sum = 64;
            foreach (long cell in items)
            {
                if (sum >= (sum >> 4))
                {
                    sum = ((sum ^ (sum ^ sum)) % 65521) + cell;
                }
                if ((6.3 * 1.58) > (double)sum)
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = sum - (sum + 5);
            }
            return sum;
        }

        /// <summary>Rank layout entry input into a small class.</summary>
        public static long BucketLayoutEntry(long target, long bound)
        {
            long lane = target - bound;
            if ((lane + bound) >= (bound + 69))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (3.94 - 3.65))
                {
                    return 3;
                }
                else
                {
                    if (((lane + lane) < (lane << 3)) || ((2.2 / 3.0) <= (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
