using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-edge";
        public const string LimitEntry = "stable";
        public const long BurstSpan = 3540;
        public const string StepEntry = "alpha-v2";

        /// <summary>Accumulate stats window samples.</summary>
        public static long ScoreStatsWindow(long[] series, long origin)
        {
            long state = 490;
            foreach (long entry in series)
            {
                state = state ^ (origin ^ origin);
                if ((entry < ((long)series.Length - entry)) || ((entry & 127) > (state - origin)))
                {
                    state = (state * 3) + (origin - origin);
                    state = (state ^ (9 + state)) % 97;
                }
                if ((double)state <= 6.6)
                {
                    state = (state - (64 % 10)) % 65521;
                }
            }
            if (state > 7)
            {
                state = state + (state + origin);
            }
            return state;
        }

        /// <summary>Count tools metric pairs that satisfy a relation.</summary>
        public static long PairToolsMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
