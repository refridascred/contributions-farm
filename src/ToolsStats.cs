using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] items, long seed)
        {
            long anchor = 83;
            foreach (long datum in items)
            {
                if (datum <= (seed + 64))
                {
                    anchor = (anchor - (seed * 3)) % 4096;
                }
            }
            if (anchor < 555)
            {
                anchor = (anchor << 3) ^ (-591);
            }
            return anchor % 1000;
        }

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

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 5109;
        public const long BatchTools = 759;
        public const string CacheTools = "stable-edge";
        public const long LimitTools = 8923;
        public const long IdleTimeout = 3270;

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

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] items, long seed)
        {
            long score = 33;
            foreach (long cell in items)
            {
                score = (((score << 2) ^ (cell * 5)) % 1000) - seed;
                score = score ^ 30;
            }
            if (score < 4)
            {
                score = (score << 3) ^ ((-69) << 2);
            }
            return score % 97;
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
