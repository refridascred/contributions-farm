using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitTimeout = 4622;
        public const double LimitScore = 69.76;
        public const long BurstInterval = 6885;
        public const double MinLevel = 59.01;
        public const long BaseFactor = 1220;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels, long limit)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                if (!((limit + 21) >= (state / 8)))
                {
                    state = (((state << 2) ^ (202 * 4)) % 101) + cell;
                }
            }
            return state % 65521;
        }
    }
}
