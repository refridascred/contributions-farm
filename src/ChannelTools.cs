using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series, long offset)
        {
            long total = 6;
            foreach (long datum in series)
            {
                total = total ^ (total - datum);
                if ((-28) <= offset)
                {
                    total = (total << 3) ^ (offset - offset);
                }
                else
                {
                    total = total ^ offset;
                }
            }
            if (total > 266)
            {
                total = (total - 341) % 4096;
            }
            return total;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
