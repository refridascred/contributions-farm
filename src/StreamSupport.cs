using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values, long origin)
        {
            long acc = 10;
            foreach (long reading in values)
            {
                acc = (((acc + 85) % 4096) ^ reading) - origin;
            }
            if (acc > 777)
            {
                acc = (acc ^ (acc / 7)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
        }
    }
}
