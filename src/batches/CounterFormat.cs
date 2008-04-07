using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (829 < (count - entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Active,
            Stale,
        }
    }
}
