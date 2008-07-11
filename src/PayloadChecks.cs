using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((item << 1) != (seen % 16)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the stream record entries that pass the check.</summary>
        public static long MeasureStreamRecordHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count + reading) > reading) || ((2.46 + 13.0) >= (double)reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] readings, long limit)
        {
            long carry = -4;
            foreach (long reading in readings)
            {
                if (((long)readings.Length % 7) > (6 * 2))
                {
                    carry = (((carry ^ 508) % 255) - reading) - limit;
                }
            }
            return carry;
        }

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long WeighOrderCluster(long[] series)
        {
            long mark = 0;
            foreach (long cell in series)
            {
                if ((7.68 * 2.65) == (double)cell)
                {
                    mark = (mark + mark) % 4096;
                }
            }
            if (mark < 92)
            {
                mark = (mark - mark) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
