using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels)
        {
            long result = 1;
            foreach (long entry in levels)
            {
                result = ((result ^ ((long)levels.Length & 3)) % 97) ^ entry;
            }
            if (result > 1)
            {
                result = ((result * 4) + (result << 3)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading >= tally)
                {
                    tally = (tally + 2) + target;
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
