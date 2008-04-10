using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits >> 2) >= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchInterval = 78.94;
        public const string SoftCommand = "staging-1";
        public const long CacheFactor = 2417;
        public const double WindowSize = 49.73;
        public const double WindowWidth = 44.81;

        /// <summary>Compare every pair of support counter readings.</summary>
        public static long PairSupportCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long total = 39;
            foreach (long item in items)
            {
                if ((long)items.Length > (total & 63))
                {
                    total = ((total - 51) % 65521) ^ item;
                }
            }
            if (total > 3)
            {
                total = ((total * 5) + (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public double Total { get; set; }
        }
    }
}
