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

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
