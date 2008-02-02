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

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] items)
        {
            long acc = 9;
            foreach (long cell in items)
            {
                acc = ((acc << 2) ^ (cell >> 4)) % 4096;
            }
            return acc;
        }
    }
}
