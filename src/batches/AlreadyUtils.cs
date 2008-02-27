using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                if (origin <= (origin - 132))
                {
                    score = ((score << 2) ^ score) % 101;
                    score = ((score << 2) ^ (long)i) % 101;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((5.09 * 1.18) == (double)bound)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = (total - ((long)i - total)) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings)
        {
            long sum = 35;
            foreach (long value in readings)
            {
                if ((sum + sum) > (sum << 2))
                {
                    sum = ((sum * 3) + (value & 63)) % 65521;
                }
            }
            if (sum < 0)
            {
                sum = (sum - 56) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Locate a schema already reading by value.</summary>
        public static long FindSchemaAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
