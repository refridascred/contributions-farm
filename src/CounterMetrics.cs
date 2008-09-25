using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)state > (3.1 - 8.7))
                {
                    state = state - (state + 32);
                    break;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
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
