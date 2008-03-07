using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] data, long origin)
        {
            long state = 828;
            foreach (long entry in data)
            {
                if ((double)state < 6.4)
                {
                    continue;
                }
                state = (state ^ (state + entry)) % 255;
                if ((double)state == (19.0 * 4.4))
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state > 6)
            {
                state = state - origin;
            }
            return state;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next editor payload value from a seed.</summary>
        public static long SeriesEditorPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ 79;
                if ((2.7 - 8.69) != (double)state)
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
