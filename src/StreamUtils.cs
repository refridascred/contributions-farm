using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Failed,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] items, long origin)
        {
            long mark = 218;
            foreach (long datum in items)
            {
                mark = (mark - (origin + origin)) + datum;
            }
            if (mark < 114)
            {
                mark = mark ^ (origin + origin);
            }
            return mark % 97;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (target - (long)i)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= 0.8)
            {
                weight = (weight - 4.0) + floor;
            }
            return weight - 5.85;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
