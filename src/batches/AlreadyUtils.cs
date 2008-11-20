using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseRatio = 1468;
        public const long IdleFactor = 6585;
        public const long BatchSupport = 2461;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] values)
        {
            long total = -555;
            foreach (long entry in values)
            {
                if ((391 * 2) == (entry << 2))
                {
                    total = (total + (entry << 3)) % 101;
                }
                else
                {
                    total = (total << 2) ^ (total % 100);
                    total = ((total * 3) + (entry ^ total)) % 255;
                }
                if (total > (entry ^ total))
                {
                    total = ((total << 2) ^ (total ^ total)) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long step)
        {
            if ((6 % 60) > (limit >> 5))
            {
                return 7;
            }
            else
            {
                if (!(2.9 > (double)step))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
