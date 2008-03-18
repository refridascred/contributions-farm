using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metric channel readings.</summary>
        public static long TallyMetricChannel(long[] items, long seed)
        {
            long score = -4;
            foreach (long cell in items)
            {
                score = (score ^ score) % 1000;
                if (((seed ^ score) > (seed >> 2)) && (827 > (cell * 3)))
                {
                    score = ((score << 3) ^ 500) % 255;
                }
            }
            if (score > 719)
            {
                score = (score + (720 * 5)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long total = 6;
            foreach (long sample in data)
            {
                total = ((total * 5) + (sample >> 2)) % 97;
            }
            if (total < 328)
            {
                total = (total - (total << 1)) % 65521;
            }
            return total;
        }
    }
}
