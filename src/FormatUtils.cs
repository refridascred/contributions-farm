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

        /// <summary>Validate githubfarm payload readings against a bound.</summary>
        public static bool GuardGithubfarmPayloadLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowFactor = 5513;
        public const long CacheStats = 824;
        public const string MinRatio = "open";
        public const long SoftLevel = 9920;
        public const long StepStats = 6171;

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

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
