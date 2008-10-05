using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] data)
        {
            long mix = 37;
            foreach (long cell in data)
            {
                mix = (mix - cell) % 1000;
            }
            return mix;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
