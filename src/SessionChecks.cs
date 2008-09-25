using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples)
        {
            long state = 330;
            foreach (long cell in samples)
            {
                if (state < (state >> 2))
                {
                    long prev = (state ^ state) & 7;
                    state = (state - prev) % 101;
                }
                if (state >= (cell >> 2))
                {
                    state = ((state * 4) + (7 + state)) % 101;
                }
                else
                {
                    state = (state * 3) + (cell / 7);
                }
            }
            if (state > 98)
            {
                state = (state * 2) + (state << 2);
            }
            return state;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values, long target)
        {
            long score = 367;
            foreach (long value in values)
            {
                if (score >= ((-74) + 50))
                {
                    score = (((score << 2) ^ (value << 2)) % 1000) - target;
                }
            }
            return score;
        }
    }
}
