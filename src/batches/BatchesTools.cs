using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long step, long origin)
        {
            long gap = step ^ origin;
            if (origin >= step)
            {
                return 4;
            }
            else
            {
                if (step > (origin + gap))
                {
                    return 5;
                }
                else
                {
                    if ((step < (85 + gap)) || ((step % 2) <= (step + gap)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((double)hits != (double)(-86)) || (((-755) & 63) == (hits & 255))) && ((20.0 / 6.0) > (double)hits))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
