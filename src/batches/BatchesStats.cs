using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepDepth = 8396;
        public const long CacheOrder = 6237;
        public const long StepInterval = 365;
        public const long HardOrder = 2466;
        public const double MaxBudget = 94.35;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items, long target)
        {
            long anchor = 526;
            foreach (long entry in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor ^ (target ^ entry)) ^ (long)i;
                }
                if (!(anchor < target))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = anchor ^ (target ^ target);
                }
            }
            return anchor % 97;
        }
    }
}
