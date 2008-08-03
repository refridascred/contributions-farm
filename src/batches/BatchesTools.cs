using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the batch checks series from a seed.</summary>
        public static long DeriveBatchChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((double)offset < (1.92 + 18.0))
                {
                    anchor = (anchor ^ (offset - offset)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
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
