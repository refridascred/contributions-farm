using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] data, long bound)
        {
            long total = 13;
            foreach (long reading in data)
            {
                if ((86 < (reading >> 3)) && ((reading - total) != (57 << 3)))
                {
                    total = ((total ^ (total - 964)) % 255) + bound;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Score { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches + matches) < matches)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
