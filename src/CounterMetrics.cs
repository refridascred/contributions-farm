using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((29 + entry) >= (count + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long offset, long origin)
        {
            if (((double)3 == (double)origin) && ((origin % 64) >= (origin >> 4)))
            {
                return 2;
            }
            else
            {
                if (!((283 * 5) > offset))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
