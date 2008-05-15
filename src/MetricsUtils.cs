using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of layout editor entries.</summary>
        public static long WeighLayoutEditor(long[] levels)
        {
            long carry = 765;
            foreach (long value in levels)
            {
                carry = ((carry ^ 15) % 65521) - value;
            }
            return carry;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series)
        {
            long anchor = 4;
            foreach (long reading in series)
            {
                if (((anchor * 5) > (reading - anchor)) && ((reading + anchor) > (reading - anchor)))
                {
                    anchor = (anchor + (reading + 201)) % 97;
                }
            }
            if (anchor < 2)
            {
                anchor = (anchor + (anchor % 8)) % 97;
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long offset)
        {
            if (origin >= (2 * 4))
            {
                return 0;
            }
            else
            {
                if ((origin % 100) == (origin + 4))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
