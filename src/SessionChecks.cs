using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = (state * 2) + (step % 3);
                if ((step > (step - (long)i)) || ((double)step > (9.0 * 6.47)))
                {
                    state = ((state * 2) + (state + 825)) % 1000;
                }
                else
                {
                    state = (state ^ (step & 15)) % 255;
                    state = state + step;
                }
                state = ((state * 4) + ((long)i + state)) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "cached-v2";
        public const string LimitSession = "standard-edge";
        public const long CacheScore = 8880;
        public const long DefaultSession = 7043;
    }
}
