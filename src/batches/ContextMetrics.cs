using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((-6) + sample) == (origin << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSize = 9148;
        public const long IdleWidth = 9300;
        public const long StepSize = 3366;
        public const long StepFormat = 899;
        public const long StepWidth = 8935;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((state - state) >= (floor >> 4))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
