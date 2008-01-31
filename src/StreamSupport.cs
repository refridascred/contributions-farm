using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count order report pairs that satisfy a relation.</summary>
        public static long MatchOrderReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Stale,
            Locked,
            Draft,
        }
    }
}
