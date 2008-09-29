using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepCount = "strict-v2";
        public const long IdleWidth = 8939;
        public const double WindowNotes = 36.03;

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = (drift - (double)82) - bias2;
            }
            return drift - 7.0;
        }
    }
}
