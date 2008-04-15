using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstDepth = 88.69;
        public const long IdleSize = 1466;
        public const double BurstTools = 23.46;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already queue samples.</summary>
        public static long ScoreAlreadyQueue(long[] series, long limit)
        {
            long carry = 76;
            foreach (long reading in series)
            {
                if ((limit + carry) >= (2 + reading))
                {
                    carry = (carry + (carry << 3)) % 4096;
                }
                else
                {
                    carry = (carry - (reading - carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double ratio, double span)
        {
            double drift = (double)54 + ratio;
            if (drift < (double)9)
            {
                drift = drift - drift;
            }
            return drift + (span / 6.0);
        }
    }
}
