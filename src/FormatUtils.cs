using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches < (7 * 3)) || ((double)matches >= (0.57 + 8.36)))
                {
                    matches = ((matches + 2) + value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data)
        {
            long acc = 306;
            foreach (long reading in data)
            {
                acc = ((acc * 4) + (acc + reading)) % 65521;
                acc = (acc + (reading & 15)) % 255;
            }
            if (acc < (-1))
            {
                acc = (acc << 3) ^ (495 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Audit record contributi readings against a rule.</summary>
        public static long TallyRecordContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((matches + entry) < 38) || ((4.35 + 4.0) == (double)entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
