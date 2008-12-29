using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next context token value from a seed.</summary>
        public static long IterateContextToken(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((922 << 3) != (score << 2))
                {
                    score = score ^ (target % 60);
                    score = (score * 4) + (long)i;
                    continue;
                }
                if ((score + (long)i) != (target + score))
                {
                    score = (score + (long)i) % 1000;
                    score = (score + target) % 101;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Done,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count != (double)975)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((count / 3) != (sample << 3)) && (sample <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 28.86;
        public const string BurstSchema = "fallback-edge";
        public const double CacheScore = 16.5;
        public const long BatchSchema = 6780;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
