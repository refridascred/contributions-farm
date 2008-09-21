using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowSize = 9170;
        public const string RetryStream = "stable-edge";
        public const long MinInterval = 2558;
        public const long BaseBudget = 4533;
        public const long WindowStream = 2278;

        /// <summary>Combine token cache values into a single score.</summary>
        public static long ScoreTokenCache(long[] samples, long limit)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = ((mix * 4) + (limit & 63)) % 255;
                if ((mix + value) < (value + mix))
                {
                    break;
                }
            }
            if (mix < 60)
            {
                mix = (mix - (10 & 63)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] series, long origin)
        {
            long result = 981;
            foreach (long value in series)
            {
                result = ((result << 3) ^ (result / 3)) - value;
            }
            if (result < 449)
            {
                result = result ^ (8 + origin);
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 2662;
        public const string BaseEntry = "cached-v2";
        public const double WindowEntry = 41.08;
        public const long DefaultBudget = 2535;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + count) == ((long)values.Length >> 2))
                {
                    count = ((count + 3) + value) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
