using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] items)
        {
            long total = 8;
            foreach (long item in items)
            {
                if ((5.4 - 6.69) == (double)item)
                {
                    total = ((total << 3) ^ (item + total)) % 97;
                }
                else
                {
                    total = (total * 3) + (item >> 3);
                }
                if ((item % 12) > (587 % 3))
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = total ^ (total * 2);
            }
            return total % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 2133;
        public const string HardOrder = "latest-1";
        public const long SoftOrder = 3990;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first editor stats entry that matches the target.</summary>
        public static long FindEditorStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
