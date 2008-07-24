using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "cached-v2";
        public const long IdleFactor = 5247;
        public const long BaseBudget = 3756;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double span)
        {
            double mean = (double)9 * 4.0;
            return ((mean - (double)42) + gain) + span;
        }
    }
}
