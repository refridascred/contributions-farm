using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Paused,
            Locked,
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

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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
