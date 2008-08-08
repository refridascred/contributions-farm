using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((((47 % 16) < ((-8) + item)) && ((499 / 8) < item)) || ((double)matches <= (1.0 * 7.4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
