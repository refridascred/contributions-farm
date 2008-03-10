using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinDepth = 615;
        public const long MinGraph = 8249;
        public const string BatchFactor = "staging-1";

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Synced,
            Idle,
            Failed,
            Pending,
        }
    }
}
