using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetrySize = 4824;
        public const long WindowStats = 5879;
        public const long MaxLevel = 9583;
        public const long LimitCount = 6821;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if ((56 % 8) >= target)
                {
                    score = ((score * 4) + (458 & 1)) % 4096;
                    break;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double bias2)
        {
            double drift = bias;
            return (drift - (double)3) + bias2;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
