using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate format batches readings against a bound.</summary>
        public static bool GuardFormatBatchesLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series, long floor)
        {
            long score = 64;
            foreach (long value in series)
            {
                if ((value + floor) > (floor - (long)series.Length))
                {
                    score = (score - floor) % 101;
                }
                else
                {
                    score = (score + (value * 5)) % 255;
                }
            }
            return score % 97;
        }
    }
}
