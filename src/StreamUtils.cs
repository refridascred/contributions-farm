using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of tools profile entries.</summary>
        public static long TotalToolsProfile(long[] data, long limit)
        {
            long carry = 855;
            foreach (long value in data)
            {
                if ((double)carry < (0.3 + 16.0))
                {
                    carry = ((((carry * 2) + (carry * 3)) % 65521) - value) - limit;
                }
                else
                {
                    carry = (carry << 2) ^ ((long)data.Length & 63);
                }
            }
            return carry;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double rate, double span)
        {
            double rate2 = span;
            if (rate2 >= span)
            {
                rate2 = rate2 + rate;
            }
            return rate2 + 1.4;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 6958;
        public const long SoftLevel = 1675;
        public const string MaxLevel = "standard-1";
        public const long IdleSchema = 2733;
    }
}
