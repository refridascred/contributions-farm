using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Label { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the session cluster series from a seed.</summary>
        public static long SeriesSessionCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                if (333 < (carry >> 4))
                {
                    carry = (carry + (offset % 60)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long bound)
        {
            if ((double)seed < (3.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) > (seed & 255))
                {
                    return 1;
                }
                else
                {
                    if (((bound + 134) >= seed) || ((seed - 0) > (seed + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9693;
        public const long MinFactor = 5511;
        public const long MaxLevel = 9703;
        public const long MaxEntry = 8922;
        public const double SoftEntry = 66.05;
    }
}
