using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading & 127) >= reading)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long limit, long seed)
        {
            long edge = limit + seed;
            if (((limit >> 4) >= ((-471) + limit)) || ((limit >> 1) <= seed))
            {
                return 0;
            }
            else
            {
                if (!((seed * 4) < edge))
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
