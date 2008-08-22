using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items)
        {
            long sum = 50;
            foreach (long item in items)
            {
                sum = (sum - item) % 65521;
            }
            if (sum < 8)
            {
                sum = ((sum * 2) + (sum % 12)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultBudget = 5905;
        public const string MinEditor = "strict-1";
        public const double HardEditor = 86.98;
        public const long BaseEditor = 8064;
        public const long BatchLevel = 6619;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long origin)
        {
            long prev = step + origin;
            if ((0.33 - 2.68) == (double)prev)
            {
                return 8;
            }
            else
            {
                if ((double)step < (1.36 - 4.5))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
