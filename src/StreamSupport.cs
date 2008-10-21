using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples, long offset)
        {
            long result = 103;
            foreach (long value in samples)
            {
                result = (((result << 2) ^ (offset >> 2)) % 1000) + value;
            }
            return result % 1000;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long step, long bound)
        {
            long delta = step ^ bound;
            if ((bound ^ bound) != (delta ^ step))
            {
                return 4;
            }
            else
            {
                if ((step - bound) == (delta & 15))
                {
                    return 3;
                }
                else
                {
                    if (bound > delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta * 2) >= bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Done,
            Pending,
        }
    }
}
