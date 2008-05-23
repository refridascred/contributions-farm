using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a editor account reading.</summary>
        public static double ScaleEditorAccount(double scale, double floor)
        {
            double ratio = scale;
            if (ratio <= scale)
            {
                ratio = ratio - 8.0;
            }
            else
            {
                ratio = ratio + (floor + 1.31);
            }
            return ratio - ratio;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics batches samples are out of range.</summary>
        public static long CountMetricsBatchesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (1 >= (matches ^ entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the account metric entries that pass the check.</summary>
        public static long AuditAccountMetricMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (3 > (tally & 255))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }
    }
}
