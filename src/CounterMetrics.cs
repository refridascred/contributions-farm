using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ 7) == (long)values.Length)
                {
                    count = ((count + 2) + item) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Locked,
            Ready,
            Pending,
            New,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] values)
        {
            long carry = 5;
            foreach (long value in values)
            {
                carry = carry ^ (value ^ 87);
            }
            return carry;
        }
    }
}
