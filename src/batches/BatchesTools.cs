using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item % 5) >= (2 >> 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
