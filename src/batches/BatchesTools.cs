using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((mark + mark) <= ((long)i >> 3))
                {
                    mark = ((mark << 3) ^ (seed % 24)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] items)
        {
            long anchor = 2;
            foreach (long item in items)
            {
                anchor = anchor - (96 ^ 917);
                if ((5 ^ anchor) < (item * 3))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
