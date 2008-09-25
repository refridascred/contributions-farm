using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long sum = 87;
            foreach (long sample in samples)
            {
                sum = sum ^ (sum + sample);
            }
            return sum % 65521;
        }
    }
}
