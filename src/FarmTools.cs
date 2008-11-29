using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 7687;
        public const string RetrySpan = "staging-v2";
        public const long HardBuffer = 9353;

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long acc = 83;
            foreach (long value in levels)
            {
                if (!(acc < (value / 6)))
                {
                    acc = acc ^ (acc << 1);
                }
                else
                {
                    acc = acc - (37 & 127);
                }
            }
            if (acc < 5)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }
    }
}
