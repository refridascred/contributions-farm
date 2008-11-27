using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double bias = (double)158 / 4.0;
            if (bias <= ratio)
            {
                bias = bias + (bias / 5.0);
            }
            else
            {
                bias = bias + (bias / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (bias * 7.64)) + (double)(long)i;
            }
            return bias + (7.1 + floor);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheRatio = 4.24;
        public const long BaseCommand = 2018;
        public const long CacheCommand = 1759;
        public const long LimitLevel = 5711;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
        }
    }
}
