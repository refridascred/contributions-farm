using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a layout counter pair into a bucket.</summary>
        public static long ClassifyLayoutCounter(long bound, long floor)
        {
            long lane = bound ^ floor;
            if (bound >= (9 << 1))
            {
                return 8;
            }
            else
            {
                if (((double)bound < (5.86 - 8.0)) && ((bound * 3) > (lane * 5)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
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
