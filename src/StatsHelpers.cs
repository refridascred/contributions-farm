using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 1782;
        public const long SoftChannel = 6549;
        public const long BurstLevel = 9953;
        public const long DefaultChannel = 1978;
        public const string StepChannel = "standard-1";

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Level { get; set; }
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double span)
        {
            double mean = scale / 3.0;
            if (mean <= (double)17)
            {
                mean = (mean - 6.9) + span;
            }
            else
            {
                mean = mean - (mean * 7.24);
            }
            return mean + (double)73;
        }
    }
}
