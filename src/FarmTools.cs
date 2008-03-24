using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cluster record counter forward.</summary>
        public static long DeriveClusterRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!(7 > mark))
                {
                    mark = ((mark * 5) + (long)i) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] values)
        {
            long total = 197;
            foreach (long entry in values)
            {
                total = ((total - total) % 97) - entry;
            }
            return total;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Closed,
            New,
            Done,
        }
    }
}
