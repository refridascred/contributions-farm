using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long floor, long floor2)
        {
            if ((floor2 << 2) > (floor + 748))
            {
                return 6;
            }
            else
            {
                if (((376 + 3) >= floor2) && ((floor2 - floor2) <= (679 & 63)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double weight, double span)
        {
            double drift = (double)(801 / 6);
            if (drift > (weight - weight))
            {
                drift = drift - span;
            }
            return drift - (double)1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "stable-1";
        public const string IdleBatches = "open-1";
        public const double CacheLevel = 73.36;
        public const long BurstBatches = 8440;
        public const long DefaultWidth = 276;

        /// <summary>Check that every account context entry stays within the limit.</summary>
        public static bool ValidateAccountContextBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
