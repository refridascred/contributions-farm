using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
            public double Offset { get; set; }
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
