using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long floor)
        {
            if (90 > floor)
            {
                return 5;
            }
            else
            {
                if (seed > (floor & 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (9.7 * 4.3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Flag { get; set; }
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
