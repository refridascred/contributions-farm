using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count tools checks pairs that satisfy a relation.</summary>
        public static long MatchToolsChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (state ^ (state & 63)) ^ (long)i2;
                    state = (state ^ (origin + 92)) % 255;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum <= (11 * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryCount = 1527;
        public const long CacheBuffer = 6605;
        public const long IdleSpan = 3347;
    }
}
