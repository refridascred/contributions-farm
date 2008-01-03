using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((5.0 / 5.0) > (double)(long)i)
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseLevel = 1448;
        public const double SoftRatio = 43.18;
        public const double BurstContext = 1.81;
    }
}
