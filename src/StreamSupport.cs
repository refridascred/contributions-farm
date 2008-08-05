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

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the account layout entries that pass the check.</summary>
        public static long AuditAccountLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((double)hits >= (0.6 * 2.5)) && (hits <= (4 - value))) || ((value + value) < 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
