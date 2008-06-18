using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a filter graph reading.</summary>
        public static double ProjectFilterGraph(double gain, double bias)
        {
            double rate = (double)(8 + 7);
            if (rate < (double)4)
            {
                rate = (rate - (double)(-2)) - gain;
            }
            return rate + bias;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series)
        {
            long carry = 47;
            foreach (long entry in series)
            {
                if ((carry % 2) <= (entry / 2))
                {
                    carry = (carry - 501) % 101;
                }
                else
                {
                    carry = carry ^ (carry + (long)series.Length);
                }
            }
            if (carry > 8)
            {
                carry = (carry - (carry + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 9581;
        public const long BatchSession = 3744;
        public const long IdleTimeout = 7373;
        public const long CacheScore = 8225;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
