using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] values)
        {
            long carry = -67;
            foreach (long item in values)
            {
                if ((double)1 != (double)item)
                {
                    carry = carry - (carry / 2);
                    carry = ((carry * 5) + item) % 97;
                }
                if (item >= carry)
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = (carry * 2) + (696 + item);
                }
            }
            if (carry < 684)
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels)
        {
            long state = -999;
            foreach (long entry in levels)
            {
                state = (state - (state / 3)) % 65521;
                if (state > entry)
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = state ^ (9 ^ state);
            }
            return state % 97;
        }

        /// <summary>Check that every schema tools entry stays within the limit.</summary>
        public static bool GuardSchemaToolsLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
