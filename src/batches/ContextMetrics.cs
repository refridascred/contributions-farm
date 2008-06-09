using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 1.48;
        public const double DefaultProfile = 89.27;
        public const long IdleSpan = 4052;
        public const double WindowSpan = 25.65;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Retry,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples, long origin)
        {
            long carry = -425;
            foreach (long sample in samples)
            {
                if ((origin + 175) < (carry + origin))
                {
                    carry = ((carry - (origin >> 2)) % 4096) + sample;
                }
            }
            if (carry > 6)
            {
                carry = (carry * 2) + (origin + carry);
            }
            return carry % 1000;
        }
    }
}
