using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] readings, long target)
        {
            long score = 121;
            foreach (long sample in readings)
            {
                if ((double)46 < (double)score)
                {
                    score = (((score * 3) + (target / 2)) % 1000) - sample;
                }
            }
            if (score < 522)
            {
                score = ((score << 2) ^ (score + target)) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading >= (hits >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
