using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] items, long target)
        {
            long mark = 2;
            foreach (long reading in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark + (target << 2)) % 1000) - (long)i;
                }
                if (((double)target < (3.9 - 8.7)) && ((-6) <= reading))
                {
                    mark = mark + (reading - reading);
                }
            }
            return mark;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            Retry,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long floor)
        {
            if ((6.9 / 7.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((floor - floor) < floor)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
