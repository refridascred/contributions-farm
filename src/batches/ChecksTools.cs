using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i / 2) > (long)i)
                {
                    mix = ((mix << 3) ^ (offset % 7)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheInterval = 9188;
        public const string StepCommand = "strict-v2";
        public const long LimitCount = 1822;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values, long origin)
        {
            long acc = 277;
            foreach (long sample in values)
            {
                acc = (((acc << 3) ^ (5 * 4)) % 1000) - origin;
                if ((476 + acc) <= (acc + sample))
                {
                    acc = (acc ^ (25 << 3)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }
    }
}
