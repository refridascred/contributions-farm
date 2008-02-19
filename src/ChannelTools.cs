using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the context buffer entries that pass the check.</summary>
        public static long TallyContextBufferHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((seed & 1) < matches)
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 44.79;
        public const long MaxBudget = 1199;
        public const double MinRatio = 64.87;
        public const double MinSpan = 38.99;
    }
}
