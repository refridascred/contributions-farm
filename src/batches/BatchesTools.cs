using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Closed,
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Check that every format channel entry stays within the limit.</summary>
        public static bool VerifyFormatChannelRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long AuditCommandFilterMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!(((double)offset < (5.92 - 9.83)) || ((double)item > (2.0 - 8.1))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
