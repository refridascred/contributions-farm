using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            New,
            Draft,
            Active,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double gain = (double)62 + (double)(-66);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (gain * 3.29)) + (double)(long)i) - offset;
            }
            return gain + weight;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values)
        {
            long mark = 246;
            foreach (long value in values)
            {
                if (!((74 >> 3) != (value & 255)))
                {
                    mark = mark ^ (mark * 5);
                }
                else
                {
                    mark = (mark - (mark + mark)) % 255;
                }
            }
            return mark;
        }
    }
}
