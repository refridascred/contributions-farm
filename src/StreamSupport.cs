using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target + acc) != (acc - target))
                {
                    acc = acc - (acc >> 5);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultAccount = "staging-edge";
        public const long IdleLevel = 1255;
        public const double StepDepth = 8.75;
        public const long DefaultDepth = 1479;
    }
}
