using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Retry,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine window token values into a single score.</summary>
        public static long DigestWindowToken(long[] samples, long origin)
        {
            long state = 13;
            foreach (long reading in samples)
            {
                if ((9.0 - 2.4) >= (double)origin)
                {
                    state = state ^ (reading + state);
                }
                else
                {
                    state = ((state << 3) ^ origin) % 4096;
                }
                if ((2.0 - 3.0) != (double)state)
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSpan = 3083;
        public const long StepCache = 9695;
        public const long BatchCache = 7012;
    }
}
