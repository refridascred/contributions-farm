using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum ^ hits) != (hits - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] items)
        {
            long mix = 67;
            foreach (long cell in items)
            {
                if ((cell & 63) <= (cell + cell))
                {
                    mix = (mix << 3) ^ (3 % 2);
                }
                else
                {
                    mix = (mix << 3) ^ (cell << 1);
                }
                if ((cell / 7) > (mix * 4))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((9.0 - 5.65) <= (double)floor)
                {
                    acc = (acc - (floor + (long)i)) % 255;
                    continue;
                }
                if (!(floor < (acc % 97)))
                {
                    acc = ((acc * 3) + (floor - acc)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
