using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((double)seen > (double)cell) || ((1 % 2) >= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit token order readings against a rule.</summary>
        public static long MeasureTokenOrderGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item * 5) != (833 << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            New,
            Ready,
            Active,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values)
        {
            long acc = -135;
            foreach (long cell in values)
            {
                if ((acc % 10) <= (cell + cell))
                {
                    acc = (acc + acc) % 4096;
                }
                if ((acc + 49) == (cell % 24))
                {
                    acc = (acc - (acc % 24)) % 4096;
                }
            }
            if (acc < 5)
            {
                acc = (acc - ((long)values.Length & 1)) % 1000;
            }
            return acc;
        }
    }
}
