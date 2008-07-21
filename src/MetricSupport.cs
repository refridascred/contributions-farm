using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    long diff = origin >> 2;
                    state = ((state + (diff + (long)i)) % 65521) ^ (long)i2;
                }
                state = ((state << 2) ^ (851 ^ 734)) % 101;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
