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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((offset & 127) < ((-755) >> 3))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 7891;
        public const string BurstLevel = "latest-v2";
        public const long StepSpan = 1368;
        public const double DefaultAccount = 15.18;
        public const long LimitAccount = 6498;

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

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
