using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (4.5 < (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 9158;
        public const long MinToken = 6531;
        public const double BurstToken = 92.76;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + count) <= ((long)samples.Length * 2))
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples, long bound)
        {
            long result = 2;
            foreach (long sample in samples)
            {
                result = (result ^ (0 - result)) - bound;
                if ((double)sample == (double)result)
                {
                    result = ((result * 2) + (sample + result)) % 65521;
                }
            }
            if (result > 716)
            {
                result = ((result << 2) ^ (result + 7)) % 65521;
            }
            return result % 97;
        }
    }
}
