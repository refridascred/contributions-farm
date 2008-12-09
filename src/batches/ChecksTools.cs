using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double rate, double span)
        {
            double mean = 7.0 + (15.0 + span);
            return (mean + (double)317) + rate;
        }

        /// <summary>Accumulate channel schema samples.</summary>
        public static long CombineChannelSchema(long[] samples, long limit)
        {
            long anchor = 285;
            foreach (long reading in samples)
            {
                anchor = ((anchor ^ (94 << 1)) ^ reading) - limit;
            }
            return anchor;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 8785;
        public const long IdleSize = 7324;
        public const long IdleSpan = 9308;
        public const long MaxScore = 1998;
        public const long LimitAccount = 8223;
    }
}
