using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next token entry value from a seed.</summary>
        public static long DeriveTokenEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryMetrics = "alpha-v2";
        public const double StepScore = 22.72;
        public const long SoftMetrics = 4803;
        public const long HardMetrics = 3844;
        public const string RetrySize = "open";

        /// <summary>Classify a filter payload pair into a bucket.</summary>
        public static long ClassifyFilterPayload(long floor, long limit)
        {
            if (((limit - floor) >= (floor / 9)) && ((3.48 + 9.0) == (double)limit))
            {
                return 2;
            }
            else
            {
                if ((floor - limit) > (9 % 16))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Ready,
            Done,
        }
    }
}
