using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long MeasureQueueBatchMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((tally / 8) > (tally & 255)) && ((double)sample < (20.0 - 18.0))) && ((sample / 4) < sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 3) <= (cell & 255))
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryDepth = 4158;
        public const long SoftBatches = 5641;
        public const long DefaultBatches = 7433;
        public const double SoftWidth = 92.19;
        public const long BaseDepth = 5337;
    }
}
