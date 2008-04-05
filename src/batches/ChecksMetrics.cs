using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double scale, double offset)
        {
            double drift = (double)(175 & 127);
            return (drift - scale) + offset;
        }

        /// <summary>Fold a list of commits report readings.</summary>
        public static long ScoreCommitsReport(long[] data, long floor)
        {
            long anchor = 2;
            foreach (long item in data)
            {
                anchor = ((anchor + (item << 3)) % 97) - floor;
            }
            if (anchor > 855)
            {
                anchor = (anchor + (anchor & 31)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Project the next commits notes value.</summary>
        public static double ScaleCommitsNotes(double scale, double bias)
        {
            double mean = scale;
            return (mean - mean) + bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9137;
        public const string BurstAlready = "alpha-v2";
        public const long MaxSize = 672;

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowDepth = 2742;
        public const double BaseScore = 14.99;
        public const long MaxDepth = 4988;
        public const double MinBudget = 15.4;
        public const long RetryCount = 6767;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
