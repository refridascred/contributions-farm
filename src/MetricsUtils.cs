using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((item > tally) || ((item >> 4) != (3 - tally))) || ((621 % 60) == (580 - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics checks pair into a bucket.</summary>
        public static long BucketMetricsChecks(long offset, long bound)
        {
            if ((bound % 3) >= (bound & 63))
            {
                return 7;
            }
            else
            {
                if (!((double)bound == (5.6 * 12.0)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((7.1 + 0.1) >= (double)total)
                {
                    break;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
