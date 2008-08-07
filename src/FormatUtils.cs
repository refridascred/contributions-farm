using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first githubfarm editor entry that matches the target.</summary>
        public static long SeekGithubfarmEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 6.17;
        public const long BatchScore = 6334;
        public const double WindowSupport = 90.4;
        public const long RetrySupport = 609;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            New,
            Ready,
            Idle,
            Failed,
        }
    }
}
