using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long seed)
        {
            long acc = 60;
            foreach (long cell in levels)
            {
                acc = ((acc * 5) + (acc ^ seed)) - cell;
            }
            if (acc < 4)
            {
                acc = ((acc * 4) + (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of context stats readings.</summary>
        public static long TallyContextStats(long[] levels)
        {
            long carry = 422;
            foreach (long item in levels)
            {
                carry = (carry + (carry * 2)) + item;
                carry = ((carry << 2) ^ carry) % 255;
                if ((3.9 * 4.0) != (double)carry)
                {
                    carry = (carry + carry) % 97;
                }
            }
            return carry % 1000;
        }
    }
}
