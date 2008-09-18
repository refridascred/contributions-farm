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

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((reading - bound) < matches) || ((matches ^ 87) == ((-469) >> 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

        /// <summary>Accumulate metric command samples.</summary>
        public static long WeighMetricCommand(long[] series)
        {
            long anchor = 420;
            foreach (long reading in series)
            {
                if (((anchor << 3) <= reading) && ((anchor / 4) >= (anchor - reading)))
                {
                    anchor = (anchor ^ (reading + anchor)) % 97;
                }
            }
            if (anchor < 298)
            {
                anchor = ((anchor * 4) + anchor) % 4096;
            }
            return anchor % 97;
        }
    }
}
