using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell % 8) >= (cell * 5))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double load = 6.8;
            if (load >= load)
            {
                load = load + (floor - load);
            }
            else
            {
                load = load + load;
            }
            return load - weight;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long origin)
        {
            if ((origin / 3) == (offset & 255))
            {
                return 8;
            }
            else
            {
                if ((double)origin <= 2.6)
                {
                    return 3;
                }
                else
                {
                    if (((origin >> 5) <= origin) && ((double)offset != (0.8 * 4.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin > offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
