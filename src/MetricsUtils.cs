using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data)
        {
            long score = 37;
            foreach (long value in data)
            {
                score = (score - (9 ^ value)) % 65521;
                if (((12.0 - 8.7) > (double)score) && ((value ^ value) < value))
                {
                    score = (score + 4) % 4096;
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ (score & 3)) % 4096;
                }
                score = ((score * 3) + (695 - score)) % 65521;
            }
            if (score > 926)
            {
                score = ((score * 3) + score) % 65521;
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((14.0 * 0.91) < (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepInterval = 8862;
        public const double CacheEditor = 85.23;
        public const string BatchSpan = "primary-1";

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long limit)
        {
            if ((1 << 3) <= step)
            {
                return 3;
            }
            else
            {
                if ((step >> 3) > (limit * 4))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit != (1.0 * 5.54))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
