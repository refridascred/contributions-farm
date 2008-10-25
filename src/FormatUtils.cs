using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Owner { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)6 < (double)cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((floor + anchor) == (522 + floor))
                {
                    anchor = ((anchor << 2) ^ ((long)i * 2)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor / 4)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 3) + ((long)i / 4);
                state = (state * 5) + (long)i;
                state = (state ^ state) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
