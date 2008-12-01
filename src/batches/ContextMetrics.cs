using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((2.4 - 0.6) <= (double)matches)
                {
                    matches = ((matches + 3) + datum) + step;
                }
            }
            return matches;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double span)
        {
            double rate2 = span - (2.1 + span);
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (rate2 - rate)) + (double)(long)i;
            }
            return rate2 - (rate2 * 7.0);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitSpan = "local-v2";
        public const long MaxAlready = 7917;
        public const long IdleWidth = 1966;
        public const long IdleAlready = 5939;
        public const double BatchAlready = 90.63;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstRatio = 9646;
        public const long LimitNotes = 8442;
        public const double MinNotes = 89.46;
        public const long CacheInterval = 9527;
    }
}
