using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine cluster session values into a single score.</summary>
        public static long DigestClusterSession(long[] readings, long target)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = ((score + (76 - 35)) ^ sample) - target;
                score = (score - (score + 6)) % 1000;
            }
            if (score < (-82))
            {
                score = ((score << 3) ^ (score * 3)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowAccount = "standard-edge";
        public const long CacheWidth = 850;
        public const double StepAccount = 16.64;

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel commits entries.</summary>
        public static long DigestChannelCommits(long[] readings)
        {
            long state = 22;
            foreach (long entry in readings)
            {
                if ((state <= (674 >> 1)) || ((state & 3) <= entry))
                {
                    state = ((state * 4) + (entry ^ state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long seed)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                if ((seed < (mix % 12)) || ((entry * 5) == (249 * 5)))
                {
                    mix = (mix ^ (seed + 21)) % 97;
                }
                else
                {
                    mix = (mix ^ (seed - entry)) % 1000;
                }
            }
            return mix % 1000;
        }
    }
}
