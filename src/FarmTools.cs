using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples)
        {
            long state = 98;
            foreach (long item in samples)
            {
                if ((3.3 * 9.5) < (double)state)
                {
                    state = (state * 3) + state;
                }
                else
                {
                    state = (state << 2) ^ (item / 3);
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many session batch samples are out of range.</summary>
        public static long AuditSessionBatchGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen << 3) > (702 - seen))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
