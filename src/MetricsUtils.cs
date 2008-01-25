using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 4101;
        public const long LimitSchema = 5259;
        public const string MaxSchema = "standard-1";
        public const string CacheSchema = "primary-1";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long score = 83;
            foreach (long item in series)
            {
                score = ((score << 2) ^ (item & 127)) % 1000;
                if ((item + score) == (score / 6))
                {
                    score = score ^ (score % 64);
                }
            }
            return score;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count - target) < (950 >> 5))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double rate, double offset)
        {
            double load = rate;
            return load + offset;
        }
    }
}
