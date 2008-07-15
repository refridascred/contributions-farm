using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum <= (datum % 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long score = 755;
            foreach (long sample in values)
            {
                score = (score ^ sample) % 101;
            }
            return score;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many command buffer samples are out of range.</summary>
        public static long CountCommandBufferOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell << 2) < origin)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
