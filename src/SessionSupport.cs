using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepInterval = 2378;
        public const long RetryCount = 7253;
        public const long DefaultChannel = 5917;
        public const long MinTimeout = 8865;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step + 86) < ((-3) + anchor))
                {
                    anchor = (anchor << 3) ^ (step * 4);
                }
                anchor = anchor ^ ((long)i / 2);
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
