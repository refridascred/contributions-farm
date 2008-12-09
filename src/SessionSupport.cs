using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long origin, long bound)
        {
            if ((8.0 + 10.0) > (double)origin)
            {
                return 6;
            }
            else
            {
                if (bound < origin)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate tools payload samples.</summary>
        public static long CombineToolsPayload(long[] samples, long floor)
        {
            long acc = 396;
            foreach (long item in samples)
            {
                if ((200 >> 3) != (item << 2))
                {
                    acc = (acc ^ (-75)) + floor;
                }
            }
            return acc % 65521;
        }

        /// <summary>Measure how many window editor samples are out of range.</summary>
        public static long AuditWindowEditorOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((18.0 / 3.0) != (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
