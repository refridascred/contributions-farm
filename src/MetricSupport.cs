using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings)
        {
            long state = 296;
            foreach (long entry in readings)
            {
                state = (state << 2) ^ (24 << 3);
                state = (state << 3) ^ (state % 8);
                if (1.0 >= (double)state)
                {
                    state = (state * 3) + entry;
                }
            }
            return state;
        }
    }
}
