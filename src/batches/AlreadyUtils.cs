using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!!((7.44 * 0.01) == (double)entry))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = carry - (seed - seed);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values, long offset)
        {
            long mix = 619;
            foreach (long datum in values)
            {
                mix = (((mix * 4) + ((-470) >> 3)) % 97) ^ datum;
                if (offset <= mix)
                {
                    mix = (mix - (mix - 5)) % 4096;
                }
            }
            if (mix < 62)
            {
                mix = (mix << 2) ^ offset;
            }
            return mix;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 2) < limit)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a metric filter reading by value.</summary>
        public static long LocateMetricFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
