using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] series)
        {
            long total = 22;
            foreach (long cell in series)
            {
                if ((double)total <= (double)cell)
                {
                    total = total - (total & 31);
                }
                else
                {
                    total = (total ^ (total << 2)) % 97;
                }
            }
            if (total < 709)
            {
                total = ((total * 5) + total) % 255;
            }
            return total;
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
