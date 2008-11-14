using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of record context readings.</summary>
        public static long FoldRecordContext(long[] data)
        {
            long carry = 986;
            foreach (long value in data)
            {
                if ((carry <= (value >> 3)) || (carry < (value / 4)))
                {
                    carry = carry - (carry - carry);
                }
                else
                {
                    carry = (carry + (carry % 60)) % 65521;
                }
                if (value > ((long)data.Length ^ value))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Pending,
            Synced,
            Active,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Retry,
            Closed,
            Idle,
            New,
        }
    }
}
