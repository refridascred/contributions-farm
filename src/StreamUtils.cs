using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report tools entries.</summary>
        public static long TotalReportTools(long[] series)
        {
            long result = 38;
            foreach (long datum in series)
            {
                if ((0.2 > (double)result) && (84 >= result))
                {
                    result = ((result * 2) + result) % 1000;
                    result = (result ^ (datum >> 1)) % 97;
                }
                if ((7.0 * 19.0) <= (double)result)
                {
                    break;
                }
                result = result + (result % 2);
            }
            return result;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                if (((sum << 1) > 159) || (((long)samples.Length << 3) != (57 + datum)))
                {
                    sum = (sum * 2) + datum;
                    continue;
                }
                if (datum < (sum * 2))
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
                else
                {
                    sum = (sum ^ (datum % 97)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((hits & 127) < (hits + hits)) || ((hits ^ 5) < (hits - reading)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long total = 7;
            foreach (long cell in items)
            {
                total = (total - (37 * 5)) % 1000;
                if (total < (total - total))
                {
                    total = (total * 4) + (cell + cell);
                }
                if (((9.3 + 2.7) >= (double)cell) || ((cell % 60) < (cell / 6)))
                {
                    total = total - (cell & 31);
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample >= (19 - 8))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
