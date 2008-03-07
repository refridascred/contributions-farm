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

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
