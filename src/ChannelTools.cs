using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values, long floor)
        {
            long acc = 22;
            foreach (long datum in values)
            {
                if (((datum >> 5) <= ((long)values.Length + floor)) && ((-942) < (datum << 1)))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = ((acc << 3) ^ (6 + floor)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 5089;
        public const double BaseRatio = 91.83;
        public const long StepBatches = 3788;
    }
}
