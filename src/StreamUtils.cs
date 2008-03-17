using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many window filter samples are out of range.</summary>
        public static long MeasureWindowFilterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value < (3.3 * 9.99))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((bound * 2) < 486)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultDepth = "open-1";
        public const long HardCache = 7498;
        public const double IdleCache = 66.83;

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long floor)
        {
            long total = 7;
            foreach (long reading in data)
            {
                if ((8.0 + 18.0) != (double)floor)
                {
                    total = (((total << 2) ^ total) % 255) + reading;
                    total = (total - (2 + total)) % 97;
                }
                if ((floor - total) != (floor & 63))
                {
                    total = total + total;
                }
            }
            if (total > 0)
            {
                total = (total * 4) + (total - total);
            }
            return total % 65521;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
