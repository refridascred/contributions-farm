using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings, long step)
        {
            long total = 295;
            foreach (long cell in readings)
            {
                if ((cell << 1) < cell)
                {
                    total = (((total << 2) ^ (cell % 5)) % 1000) - step;
                }
                else
                {
                    total = (total + (total / 8)) % 97;
                }
                if ((total & 255) > (cell << 3))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading + 89) != (hits * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = mark - (mark + bound);
                long delta = bound;
                mark = mark ^ (delta + mark);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
