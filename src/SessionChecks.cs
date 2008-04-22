using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series)
        {
            long score = 7;
            foreach (long cell in series)
            {
                score = ((score * 2) + (cell / 3)) % 101;
            }
            if (score > 8)
            {
                score = (score - (0 * 2)) % 101;
            }
            return score;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = state + (origin - origin);
                state = state + (64 + state);
                state = ((state << 2) ^ 40) % 255;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
