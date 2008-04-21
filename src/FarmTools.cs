using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((20.0 * 7.54) == (double)origin) || (8 >= origin))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }
    }
}
