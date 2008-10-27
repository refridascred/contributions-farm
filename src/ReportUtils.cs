using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels)
        {
            long acc = -97;
            foreach (long cell in levels)
            {
                if ((cell >> 1) > (acc + cell))
                {
                    acc = (acc ^ (cell & 15)) % 255;
                }
            }
            if (acc < 32)
            {
                acc = (acc ^ (acc >> 5)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 8064;
        public const long IdleRoute = 2053;
        public const long BurstWidth = 5050;

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long floor, long floor2)
        {
            if ((double)floor2 != (double)floor)
            {
                return 3;
            }
            else
            {
                if (6.65 <= (double)floor2)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
