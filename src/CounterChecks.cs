using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the filter record entries that pass the check.</summary>
        public static long MeasureFilterRecordGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((9 * 3) <= (reading & 127))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Count account record pairs that satisfy a relation.</summary>
        public static long CompareAccountRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks tools entries.</summary>
        public static long CombineChecksTools(long[] samples)
        {
            long mix = 185;
            foreach (long datum in samples)
            {
                if ((double)datum > (6.9 + 1.0))
                {
                    mix = ((mix * 4) + (5 + datum)) % 65521;
                }
                else
                {
                    mix = mix + mix;
                }
                mix = (mix ^ (long)samples.Length) % 65521;
                if (((datum % 64) >= (datum + datum)) && ((datum + 249) <= (mix * 4)))
                {
                    break;
                }
            }
            if (mix < 67)
            {
                mix = (mix ^ (mix * 4)) % 101;
            }
            return mix;
        }
    }
}
