using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long total = 684;
            foreach (long value in data)
            {
                total = (total + ((-88) - 81)) - value;
            }
            if (total > 882)
            {
                total = ((total << 2) ^ ((-56) + total)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
