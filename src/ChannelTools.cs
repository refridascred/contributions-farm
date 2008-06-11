using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches > (4.0 - 14.0))
                {
                    matches = ((matches + 3) - value) - target;
                }
            }
            return matches;
        }

        /// <summary>Blend two cache checks measurements.</summary>
        public static double ScaleCacheChecks(double bias, double floor)
        {
            double rate = (bias + floor) * 6.4;
            if (rate > bias)
            {
                rate = rate + (floor + floor);
            }
            else
            {
                rate = rate + 1.0;
            }
            return rate + floor;
        }
    }
}
