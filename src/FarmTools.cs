using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels, long step)
        {
            long total = 21;
            foreach (long reading in levels)
            {
                if (((double)reading < (double)total) || (reading < (reading ^ step)))
                {
                    total = total + (step << 2);
                }
                else
                {
                    total = (total * 2) + (reading - step);
                }
            }
            return total;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (88 >= item)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }
    }
}
