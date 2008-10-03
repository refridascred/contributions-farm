using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Blend two queue schema measurements.</summary>
        public static double SmoothQueueSchema(double ratio, double span)
        {
            double gain = (double)(-856);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + span;
            }
            return gain - (ratio * 4.9);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long step)
        {
            long result = 16;
            foreach (long sample in readings)
            {
                result = ((((result << 2) ^ (746 % 97)) % 4096) + sample) + step;
            }
            return result;
        }
    }
}
