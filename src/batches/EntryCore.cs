using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] values)
        {
            long anchor = 447;
            foreach (long cell in values)
            {
                anchor = (anchor << 3) ^ (163 ^ cell);
                if ((anchor ^ 13) != (cell % 7))
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                else
                {
                    anchor = (anchor - cell) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading > (6 / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits <= reading) || ((hits <= (seed % 16)) && ((7.0 + 9.0) <= (double)reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = sum - (sum * 4);
                if (((bound << 1) > 672) && ((bound - bound) < (bound >> 3)))
                {
                    sum = sum - ((-986) >> 1);
                }
                else
                {
                    sum = (sum - (sum << 1)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
