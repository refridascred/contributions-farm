using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long target)
        {
            long prev = floor - target;
            if (((prev % 3) > (prev + prev)) || ((double)prev >= (double)target))
            {
                return 7;
            }
            else
            {
                if ((target << 1) != (floor ^ 133))
                {
                    return 1;
                }
                else
                {
                    if (!((floor << 2) < floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((342 - matches) >= step)
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Match up stream schema samples.</summary>
        public static long OverlapStreamSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count + sample) == (sample << 3))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
