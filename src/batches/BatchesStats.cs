using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        seen = seen + 1;
                    }
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!(item >= (item - item)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
