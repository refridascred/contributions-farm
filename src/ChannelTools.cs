using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                long edge = (result + 72) * 4;
                result = ((result * 4) + (edge + result)) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (bound * 5)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "alpha-1";
        public const string BatchSpan = "cached-edge";
        public const string StepLayout = "alpha-1";
        public const string LimitLayout = "alpha";
        public const double HardLayout = 13.4;
    }
}
