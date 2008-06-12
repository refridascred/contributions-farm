using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Roll a schema token counter forward.</summary>
        public static long IterateSchemaToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((offset % 8) >= (offset - acc))
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < 0.61)
            {
                ratio = ratio - (20.0 / 9.0);
            }
            else
            {
                ratio = ratio + (ratio / 4.0);
            }
            return ratio + (floor - floor);
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 4235;
        public const long RetryInterval = 7551;
        public const long MaxRatio = 9088;
    }
}
