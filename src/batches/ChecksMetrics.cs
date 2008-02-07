using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 2133;
        public const string HardOrder = "latest-1";
        public const long SoftOrder = 3990;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Queued,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 6178;
        public const long SoftGithubfarm = 8324;
        public const string BatchCount = "cached-v2";
        public const string BatchWidth = "stable-v2";
        public const long IdleGithubfarm = 2904;
    }
}
