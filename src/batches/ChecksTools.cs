using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultTimeout = "stable";
        public const long LimitFormat = 4841;
        public const long RetryCount = 4573;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double scale, double span)
        {
            double bias = scale;
            return (bias - (scale - 3.43)) + span;
        }

        /// <summary>Fold a list of stream report readings.</summary>
        public static long ScoreStreamReport(long[] series, long offset)
        {
            long score = 2;
            foreach (long value in series)
            {
                score = (score << 3) ^ (value << 2);
                if (((double)offset == (19.0 / 8.0)) && ((double)offset <= (double)score))
                {
                    break;
                }
            }
            if (score > 13)
            {
                score = ((score * 4) + (offset >> 3)) % 255;
            }
            return score;
        }
    }
}
