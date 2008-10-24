using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinTimeout = 9748;
        public const string WindowFilter = "local-v2";
        public const long WindowTimeout = 5120;
        public const double LimitFilter = 90.56;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry ^ matches) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 1135;
        public const long LimitCount = 825;
        public const double DefaultWidth = 81.4;
        public const long MinPayload = 4821;

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double bias, double floor)
        {
            double bias2 = (floor - 7.75) + (bias + bias);
            return bias2 + (floor + floor);
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
