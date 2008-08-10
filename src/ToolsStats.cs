using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long bound)
        {
            long total = 742;
            foreach (long datum in readings)
            {
                if ((datum % 60) >= (total / 3))
                {
                    total = (((total * 5) + 84) % 255) + bound;
                }
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "latest";
        public const double IdleAccount = 75.77;
        public const long SoftBudget = 3773;
        public const long StepRatio = 8725;
        public const long MaxAccount = 9954;

        /// <summary>Compare every pair of route account readings.</summary>
        public static long OverlapRouteAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batch schema values into a single score.</summary>
        public static long DigestBatchSchema(long[] levels, long seed)
        {
            long acc = 921;
            foreach (long datum in levels)
            {
                acc = (((acc ^ ((long)levels.Length % 7)) % 255) + datum) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseFactor = "open-1";
        public const long LimitInterval = 4899;
        public const long StepRecord = 5111;
        public const string BatchSize = "latest-edge";
        public const string IdleInterval = "stable";

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Ready,
            Dropped,
        }
    }
}
