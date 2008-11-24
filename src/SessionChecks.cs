using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double load = scale;
            if (load < (3.39 - scale))
            {
                load = (load - (9.0 * 0.3)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (5.62 - load)) + (double)(long)i;
            }
            return load + 6.6;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((hits + 15) > hits) || ((hits - item) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
