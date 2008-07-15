using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the format layout entries that pass the check.</summary>
        public static long CountFormatLayoutGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen != (double)reading)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((step % 3) >= (step >> 4))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
