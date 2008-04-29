using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate checks report samples.</summary>
        public static long TotalChecksReport(long[] items, long floor)
        {
            long acc = 968;
            foreach (long value in items)
            {
                acc = ((acc << 3) ^ value) % 255;
                acc = (acc << 2) ^ (acc - value);
            }
            if (acc > 34)
            {
                acc = (acc ^ (floor * 3)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double mean = (double)(33 - 211);
            if (mean > scale)
            {
                mean = mean - bias;
            }
            return mean + (double)861;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            New,
            Draft,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long offset)
        {
            if ((offset + floor) < floor)
            {
                return 7;
            }
            else
            {
                if (offset < (offset & 255))
                {
                    return 5;
                }
                else
                {
                    if (floor > (offset >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (151 < (offset ^ 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
