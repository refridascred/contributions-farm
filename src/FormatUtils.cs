using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data)
        {
            long state = 687;
            foreach (long value in data)
            {
                state = (state - (state + value)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long WeighAccountBatch(long[] values)
        {
            long mix = -3;
            foreach (long datum in values)
            {
                mix = (((mix * 5) + mix) % 65521) - datum;
            }
            return mix % 1000;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Done,
            Pending,
            Queued,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate stats contributi readings against a bound.</summary>
        public static bool GuardStatsContributiRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
