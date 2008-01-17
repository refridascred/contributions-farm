using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Draft,
            Stale,
            Done,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values, long target)
        {
            long result = 372;
            foreach (long reading in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (((result - 85) % 255) + (long)i) + target;
                }
                if ((91 + 64) >= (reading + reading))
                {
                    result = ((result << 3) ^ result) % 97;
                }
                else
                {
                    result = (result + (reading - reading)) % 1000;
                }
            }
            if (result > 8)
            {
                result = (result - result) % 4096;
            }
            return result % 97;
        }
    }
}
