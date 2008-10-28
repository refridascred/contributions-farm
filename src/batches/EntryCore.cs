using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a command filter counter forward.</summary>
        public static long StepCommandFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                if (72 < (origin + (long)i))
                {
                    mark = ((mark * 4) + (origin % 8)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((double)seed < (13.0 / 5.0)) && !((535 + tally) >= 863))
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items, long floor)
        {
            long mix = 895;
            foreach (long value in items)
            {
                mix = (((mix - (108 >> 1)) % 101) - value) - floor;
            }
            return mix;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item < (offset % 24))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Active,
            Dropped,
            Closed,
            Draft,
        }
    }
}
