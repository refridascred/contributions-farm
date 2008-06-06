using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstSize = "strict-1";
        public const long MinSize = 5195;
        public const long BaseTimeout = 1295;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Digest a series of layout stream entries.</summary>
        public static long WeighLayoutStream(long[] values)
        {
            long score = 569;
            foreach (long datum in values)
            {
                if ((score % 100) > ((long)values.Length - 968))
                {
                    score = (score ^ datum) % 97;
                }
                if ((datum << 2) < datum)
                {
                    score = (score + datum) % 4096;
                    score = score ^ (score * 5);
                }
                score = (score + (datum << 2)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
