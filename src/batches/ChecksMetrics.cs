using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Draft,
            Locked,
            Done,
        }
    }
}
