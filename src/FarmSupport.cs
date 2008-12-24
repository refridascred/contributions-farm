using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] items, long seed)
        {
            long total = 5;
            foreach (long sample in items)
            {
                total = ((total - (sample - 0)) % 97) - seed;
            }
            return total;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell + tally) <= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((seen << 1) >= (datum + seen)) || ((double)(long)levels.Length == (double)datum)) || !((seen + datum) <= (datum + datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] items, long target)
        {
            long result = 555;
            foreach (long item in items)
            {
                result = (result - (item % 97)) % 4096;
                if (((item & 31) <= target) && ((double)target >= (9.7 + 0.08)))
                {
                    result = (result + (target - result)) % 4096;
                }
                else
                {
                    result = result + (1 - item);
                }
            }
            if (result > 5)
            {
                result = result + result;
            }
            return result % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepSize = 95.87;
        public const long HardPayload = 2666;
        public const long MinPayload = 6847;
    }
}
