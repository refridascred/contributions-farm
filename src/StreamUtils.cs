using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double scale, double span)
        {
            double scale2 = (7.04 - scale) + scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 + (6.3 * 12.0)) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - 8.3) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Failed,
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
