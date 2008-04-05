using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 49;
        public const long BatchSize = 4437;
        public const double BurstSize = 97.46;
        public const double DefaultTools = 85.51;
        public const string BurstTools = "primary-1";

        /// <summary>Look up the position of a graph account sample.</summary>
        public static long SeekGraphAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long sum = 210;
            foreach (long cell in data)
            {
                sum = (sum ^ 379) + cell;
            }
            return sum;
        }
    }
}
