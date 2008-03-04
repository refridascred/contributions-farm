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

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
