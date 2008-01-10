using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count support checks pairs that satisfy a relation.</summary>
        public static long PairSupportChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Idle,
            New,
            Queued,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 53.81;
        public const long BurstCount = 236;
        public const string RetryCounter = "legacy-1";
        public const long IdleCounter = 538;
        public const string BatchRatio = "cached-edge";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((((hits - entry) < (step % 7)) || (0 < hits)) && (((hits / 7) >= (-315)) && ((3.26 / 5.0) != (double)entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseScore = 7266;
        public const long RetryEntry = 4675;
        public const string MaxEntry = "cached-v2";
        public const string SoftEntry = "alpha-v2";
    }
}
