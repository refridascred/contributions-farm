using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double bias, double floor)
        {
            double rate = floor;
            if (rate >= rate)
            {
                rate = (rate + 10.0) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels)
        {
            long total = 400;
            foreach (long reading in levels)
            {
                if (reading < (total << 1))
                {
                    total = (total << 3) ^ (total >> 3);
                }
            }
            return total;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
