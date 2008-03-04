using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Accumulate order layout samples.</summary>
        public static long DigestOrderLayout(long[] samples, long origin)
        {
            long acc = -3;
            foreach (long datum in samples)
            {
                if (datum > acc)
                {
                    acc = ((acc << 2) ^ (datum % 10)) - origin;
                }
                else
                {
                    acc = acc ^ (26 / 2);
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine graph entry values into a single score.</summary>
        public static long DigestGraphEntry(long[] levels)
        {
            long score = 87;
            foreach (long sample in levels)
            {
                score = ((score - score) % 1000) ^ sample;
            }
            return score;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
