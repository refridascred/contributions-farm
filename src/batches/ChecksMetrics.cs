using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values, long origin)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = (sum + (2 - origin)) + value;
                if ((5.7 - 0.5) <= (double)origin)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] items, long floor)
        {
            long mark = 12;
            foreach (long reading in items)
            {
                if (6 <= reading)
                {
                    mark = ((mark + (reading * 4)) % 97) + floor;
                }
            }
            return mark;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double gain, double floor)
        {
            double load = floor + (double)50;
            if (load > (double)1)
            {
                load = (load + floor) - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)85) + (double)(long)i;
            }
            return load + (floor + floor);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
