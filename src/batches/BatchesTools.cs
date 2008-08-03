using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Active,
            Done,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix - ((long)i + (long)i)) % 1000;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
