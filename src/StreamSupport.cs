using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!!((floor << 2) <= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long step, long origin)
        {
            long span = step ^ origin;
            if (!((2.61 * 3.81) != (double)step))
            {
                return 0;
            }
            else
            {
                if ((double)origin <= (17.0 + 4.04))
                {
                    return 6;
                }
                else
                {
                    if (!(span < (span >> 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Pending,
            Locked,
        }
    }
}
