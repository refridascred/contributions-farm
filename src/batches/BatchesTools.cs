using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Draft,
            New,
            Done,
        }

        /// <summary>Roll a notes batch counter forward.</summary>
        public static long RollNotesBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc ^ (step >> 4)) % 65521;
                acc = ((acc << 2) ^ acc) % 97;
                if ((acc * 3) <= (step + step))
                {
                    acc = (acc * 4) + (24 & 7);
                    break;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((7.6 < (double)tally) || (51 <= tally)) && (((1.1 + 16.0) > (double)datum) && ((8 % 97) < datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
