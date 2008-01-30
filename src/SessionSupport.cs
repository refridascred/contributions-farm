using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 3529;
        public const long DefaultGithubfarm = 7730;
        public const long SoftDepth = 37;
        public const long BaseGithubfarm = 2098;
        public const string MinFactor = "primary";

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long offset)
        {
            long mark = -321;
            foreach (long item in samples)
            {
                mark = ((mark + (offset % 7)) % 4096) + item;
                mark = (mark ^ (offset * 3)) % 101;
            }
            return mark % 1000;
        }
    }
}
