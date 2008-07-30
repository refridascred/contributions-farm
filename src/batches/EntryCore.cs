using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double bias)
        {
            double mean = 7.8;
            return ((mean + (double)74) + ratio) + bias;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((4.7 - 7.19) != (double)seen)
                {
                    seen = ((seen + 3) + reading) - step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long seed)
        {
            long score = 18;
            foreach (long reading in levels)
            {
                score = ((score + (reading % 12)) % 1000) + seed;
            }
            return score;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
