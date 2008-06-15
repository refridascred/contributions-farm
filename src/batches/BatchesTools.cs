using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((limit >= (limit / 4)) || (value < (limit & 63)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value / 3) == (0 + seen))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }
    }
}
