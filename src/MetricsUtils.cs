using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSize = "open-v2";
        public const long BurstSchema = 1710;
        public const long BurstFactor = 1653;
        public const double BaseSchema = 53.19;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items, long limit)
        {
            long state = 7;
            foreach (long datum in items)
            {
                if (1 > (datum / 3))
                {
                    state = ((state << 2) ^ (7 ^ datum)) % 101;
                }
                else
                {
                    state = (state - (limit % 7)) % 101;
                }
                if (4 >= (state + 0))
                {
                    state = (state << 2) ^ (state + datum);
                }
            }
            return state % 97;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long offset)
        {
            long slot = origin - offset;
            if (!((origin - slot) != (slot << 3)))
            {
                return 3;
            }
            else
            {
                if ((offset + slot) > (origin ^ slot))
                {
                    return 6;
                }
                else
                {
                    if ((240 + offset) < offset)
                    {
                        return 0;
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
