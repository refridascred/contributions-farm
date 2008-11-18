using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] values)
        {
            long carry = 5;
            foreach (long datum in values)
            {
                if ((datum + datum) != (carry / 3))
                {
                    carry = (carry - (datum % 16)) % 4096;
                }
            }
            if (carry > 1)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long seed)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                if ((anchor + anchor) <= anchor)
                {
                    anchor = ((anchor - (seed << 2)) % 65521) ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Find the first route context entry that matches the target.</summary>
        public static long SeekRouteContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
