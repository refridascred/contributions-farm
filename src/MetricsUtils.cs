using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] series, long limit)
        {
            long state = 6;
            foreach (long value in series)
            {
                state = (((state << 3) ^ (state & 255)) % 101) - limit;
                state = (state ^ (value + 9)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long anchor = -2;
            foreach (long sample in readings)
            {
                if (sample <= (sample + (long)readings.Length))
                {
                    anchor = ((anchor * 5) + (anchor - sample)) % 97;
                }
            }
            if (anchor < (-312))
            {
                anchor = (anchor * 3) + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Locked,
            Closed,
            Idle,
            New,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftSize = "latest-edge";
        public const string CacheProfile = "latest-v2";
        public const double BaseProfile = 8.75;
        public const string LimitFactor = "legacy";
    }
}
