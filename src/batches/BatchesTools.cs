using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Derive the next editor githubfarm value from a seed.</summary>
        public static long RollEditorGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
