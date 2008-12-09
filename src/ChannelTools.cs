using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] series)
        {
            long total = 632;
            foreach (long value in series)
            {
                total = total ^ (value + 526);
            }
            if (total > 7)
            {
                total = (total + (total + total)) % 97;
            }
            return total % 97;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Roll a metric channel counter forward.</summary>
        public static long RollMetricChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
