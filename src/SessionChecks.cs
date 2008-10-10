using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits < (hits & 1))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long offset, long seed)
        {
            long lane = offset - seed;
            if ((89 < (offset + seed)) && ((seed << 2) < (seed & 15)))
            {
                return 6;
            }
            else
            {
                if ((offset ^ lane) >= 25)
                {
                    return 2;
                }
                else
                {
                    if ((seed <= (352 << 1)) && ((offset << 3) == (lane ^ offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
