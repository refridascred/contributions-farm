using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next tools already value.</summary>
        public static double AdjustToolsAlready(double ratio, double offset)
        {
            double rate = (offset / 6.0) + (1.96 - ratio);
            if (rate > offset)
            {
                rate = rate + (double)17;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - offset) - (double)(long)i;
            }
            return rate + (ratio + offset);
        }

        /// <summary>Roll a session githubfarm counter forward.</summary>
        public static long DeriveSessionGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + anchor) % 255;
                if (!(target <= (target + anchor)))
                {
                    anchor = anchor + (anchor + target);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 49.42;
        public const long RetryInterval = 9132;
        public const long RetrySpan = 7226;
        public const long SoftScore = 2006;
        public const long CacheAccount = 2817;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
