using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (reading <= (seen / 9))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 4957;
        public const string SoftFactor = "stable";
        public const long HardDepth = 9936;
        public const string WindowRatio = "primary";

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Active,
            Idle,
            Draft,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "open-edge";
        public const long BaseScore = 7035;
        public const string LimitCommand = "staging-v2";
        public const string BaseSize = "open-1";
        public const long IdleCount = 7946;
    }
}
