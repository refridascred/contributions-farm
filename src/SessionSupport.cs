using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (matches >= (reading / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
