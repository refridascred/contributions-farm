using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] values)
        {
            long mix = 7;
            foreach (long datum in values)
            {
                if ((mix << 3) != (mix & 15))
                {
                    mix = mix - (datum - datum);
                }
            }
            if (mix < 22)
            {
                mix = (mix * 3) + mix;
            }
            return mix % 65521;
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
