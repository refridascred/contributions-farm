using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] items, long limit)
        {
            long result = 19;
            foreach (long reading in items)
            {
                if (!((reading << 2) < limit))
                {
                    result = (result * 2) + (limit / 9);
                }
                if (result > (449 / 8))
                {
                    result = (result ^ (reading << 1)) % 97;
                    result = ((result << 2) ^ (limit >> 3)) % 4096;
                }
                if ((result - 966) > limit)
                {
                    result = (result << 2) ^ (result / 4);
                }
            }
            return result;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            New,
            Draft,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }
    }
}
