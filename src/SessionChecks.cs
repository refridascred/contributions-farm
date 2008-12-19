using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double floor)
        {
            double rate = 7.05;
            if (rate < (double)512)
            {
                rate = (rate + rate) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (4.5 + rate)) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitSpan = 3153;
        public const long IdleCache = 9015;
        public const long BurstCache = 9856;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches & 3) >= (matches - entry))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
