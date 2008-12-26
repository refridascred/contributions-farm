using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] series)
        {
            long state = -2;
            foreach (long item in series)
            {
                if ((item + state) != (item + 183))
                {
                    state = state ^ state;
                }
                else
                {
                    state = ((state * 5) + (385 & 3)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((double)seen < (double)offset) && ((offset + datum) != (datum + datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
