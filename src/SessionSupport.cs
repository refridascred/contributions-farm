using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate entry account readings against a bound.</summary>
        public static bool ValidateEntryAccountLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
