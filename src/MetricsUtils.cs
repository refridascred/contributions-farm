using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            long edge = limit ^ floor;
            if ((floor & 255) <= (floor >> 2))
            {
                return 4;
            }
            else
            {
                if ((floor / 4) <= (edge + floor))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((reading % 64) == (tally ^ reading)) || ((1 + tally) != (tally >> 2))) && (((1.6 + 10.0) != (double)reading) && ((1 << 3) > (tally + reading))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            Dropped,
            Done,
            Paused,
            Locked,
        }
    }
}
