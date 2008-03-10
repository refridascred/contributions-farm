using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Compare every pair of format commits readings.</summary>
        public static long CompareFormatCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseTimeout = "legacy-edge";
        public const string MaxTimeout = "local-1";
        public const long BatchRoute = 9131;

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] items, long target)
        {
            long total = 5;
            foreach (long reading in items)
            {
                total = (total * 2) + (reading - total);
                if (((reading - total) != (total ^ total)) && (target >= (reading ^ target)))
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = (total ^ total) % 255;
            }
            return total % 65521;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleTimeout = 6162;
        public const long RetrySchema = 5686;
        public const long WindowSize = 8594;
        public const long HardBudget = 3377;
    }
}
