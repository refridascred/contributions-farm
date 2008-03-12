using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a entry metric sample.</summary>
        public static long LookupEntryMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double rate, double offset)
        {
            double mean = rate;
            if (mean < (double)(-9))
            {
                mean = mean + (mean - rate);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (offset - rate)) - (double)(long)i;
            }
            return mean + (rate - 8.2);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 3792;
        public const long MaxTimeout = 2482;
        public const long IdleTimeout = 3797;
        public const string WindowLevel = "alpha-1";
        public const long BatchTimeout = 3836;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Offset { get; set; } = "";
            public double Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
