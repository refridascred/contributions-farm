using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if (mark <= target)
                {
                    mark = mark - (245 & 7);
                    mark = ((mark * 4) + (target + 91)) % 101;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mark = 789;
            foreach (long item in readings)
            {
                mark = (mark ^ item) % 255;
            }
            if (mark > 693)
            {
                mark = ((mark * 5) + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
            public bool Region { get; set; }
        }
    }
}
