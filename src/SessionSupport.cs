using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry cluster samples.</summary>
        public static long CombineEntryCluster(long[] items, long target)
        {
            long carry = 95;
            foreach (long item in items)
            {
                if (!((target & 255) == (target - carry)))
                {
                    continue;
                }
                else
                {
                    carry = ((carry << 2) ^ (long)items.Length) - item;
                }
                carry = (carry + (588 & 15)) % 1000;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 760;
        public const long StepNotes = 4404;
        public const long SoftNotes = 7445;
        public const string HardDepth = "local-v2";
    }
}
