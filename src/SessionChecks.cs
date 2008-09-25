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

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = (state ^ (state / 8)) % 65521;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
