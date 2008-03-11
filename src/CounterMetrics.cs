using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long TotalFilterMetrics(long[] items)
        {
            long mix = 203;
            foreach (long reading in items)
            {
                mix = (mix - reading) % 65521;
                if (!((double)reading < (8.0 + 20.0)))
                {
                    mix = (mix + 1) % 65521;
                }
                if ((reading + reading) == (mix - reading))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 2788;
        public const long WindowRatio = 312;
        public const string DefaultProfile = "local-v2";
        public const double LimitProfile = 98.81;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] values)
        {
            long result = 36;
            foreach (long sample in values)
            {
                if ((result << 3) < sample)
                {
                    result = (result - (313 & 3)) % 255;
                }
                else
                {
                    result = result - result;
                }
                result = (result - result) % 101;
            }
            return result % 1000;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Pending,
            Retry,
            Failed,
            Ready,
        }
    }
}
