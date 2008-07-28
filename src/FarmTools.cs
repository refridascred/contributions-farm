using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading + tally) >= (reading - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache tools samples.</summary>
        public static long CombineCacheTools(long[] levels, long origin)
        {
            long anchor = 150;
            foreach (long value in levels)
            {
                if ((double)origin == (double)anchor)
                {
                    anchor = (((anchor * 5) + (anchor / 9)) % 255) - value;
                }
            }
            if (anchor < 17)
            {
                anchor = ((anchor * 4) + (288 % 2)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Pending,
            Draft,
        }
    }
}
