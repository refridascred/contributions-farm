using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double bias, double bias2)
        {
            double rate = 9.0 * 12.0;
            return ((rate - (double)5) + bias) + bias2;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleTimeout = 4016;
        public const long LimitRecord = 739;
        public const long StepInterval = 9638;
    }
}
