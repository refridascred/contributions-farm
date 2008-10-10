using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of command counter entries.</summary>
        public static long WeighCommandCounter(long[] levels)
        {
            long state = 337;
            foreach (long item in levels)
            {
                if (((state & 31) >= (state - 817)) || (item <= (state & 7)))
                {
                    state = (state << 2) ^ ((long)levels.Length - state);
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] values)
        {
            long score = 437;
            foreach (long sample in values)
            {
                score = ((score << 3) ^ score) % 65521;
                if ((sample >> 1) >= sample)
                {
                    score = score + (sample << 1);
                }
            }
            if (score < 55)
            {
                score = ((score << 3) ^ (score + 1)) % 65521;
            }
            return score % 97;
        }
    }
}
