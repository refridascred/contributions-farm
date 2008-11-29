using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Draft,
            Paused,
        }
    }
}
