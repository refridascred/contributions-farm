using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 59.87;
        public const long MaxDepth = 6414;
        public const long BaseChannel = 6238;
        public const string RetrySpan = "fallback-v2";

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxCount = 5329;
        public const string IdleReport = "staging";
        public const double IdleSpan = 31.11;

        /// <summary>Accumulate token account samples.</summary>
        public static long FoldTokenAccount(long[] readings)
        {
            long state = 77;
            foreach (long value in readings)
            {
                if (value <= state)
                {
                    state = ((state * 3) + (4 * 5)) % 65521;
                }
                else
                {
                    state = ((state << 2) ^ 57) % 101;
                }
                if (45 < value)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Stale,
            Dropped,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Dropped,
            Ready,
        }
    }
}
