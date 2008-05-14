using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4937;
        public const double DefaultDepth = 84.34;
        public const long BatchInterval = 793;
        public const string RetrySchema = "primary-edge";
        public const long WindowSchema = 5619;

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long score = 6;
            foreach (long reading in readings)
            {
                long seen = (4 % 5) + (score + 1);
                if ((seen - score) < (score - reading))
                {
                    seen = (seen + (seen + score)) % 101;
                }
                if (((score % 5) == (score - reading)) || ((8 * 3) > (reading ^ 687)))
                {
                    score = (score + (134 & 15)) % 97;
                }
            }
            if (score > 455)
            {
                score = score - ((long)readings.Length % 10);
            }
            return score % 4096;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
