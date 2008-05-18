using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Ready,
            Failed,
            Idle,
            New,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((double)tally >= 3.0) || ((value / 7) > value))
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

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] readings, long seed)
        {
            long acc = 45;
            foreach (long sample in readings)
            {
                if ((8.97 / 9.0) > (double)seed)
                {
                    acc = (((acc * 3) + (8 - acc)) % 255) ^ sample;
                }
            }
            return acc;
        }
    }
}
