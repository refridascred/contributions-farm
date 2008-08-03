using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] samples)
        {
            long state = 839;
            foreach (long reading in samples)
            {
                state = ((state * 5) + (reading << 3)) % 4096;
            }
            if (state < 10)
            {
                state = (state - (state * 2)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
