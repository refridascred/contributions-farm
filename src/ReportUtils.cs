using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a graph metrics reading by value.</summary>
        public static long FindGraphMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((item < (item << 1)) || ((item + matches) > (-13))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
