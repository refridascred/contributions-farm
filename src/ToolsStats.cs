using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two farm profile measurements.</summary>
        public static double ProjectFarmProfile(double ratio, double floor)
        {
            double scale = (floor - ratio) / 4.0;
            if (scale <= (double)(-40))
            {
                scale = scale - (double)84;
            }
            else
            {
                scale = scale - (8.2 * 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 5.9) + (double)(long)i;
            }
            return scale - (floor / 4.0);
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels, long limit)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                if (sample <= 809)
                {
                    result = result - (limit >> 4);
                }
            }
            if (result > 29)
            {
                result = result - (0 / 5);
            }
            return result % 65521;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardInterval = 7369;
        public const long MinOrder = 5238;
        public const long SoftOrder = 4463;
        public const double BurstSize = 4.05;
        public const string MaxRatio = "stable-v2";
    }
}
