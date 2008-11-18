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

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleTimeout = 3611;
        public const string DefaultLevel = "strict-v2";
        public const string BatchGraph = "stable-v2";
        public const double HardRatio = 63.46;
        public const long MinDepth = 2153;

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
