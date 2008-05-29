using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next account counter value from a seed.</summary>
        public static long DeriveAccountCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                long hits = (long)i;
                if (((target - hits) <= (target * 5)) || ((sum + hits) >= (82 % 7)))
                {
                    sum = (sum - ((long)i + target)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 32.89;
        public const long IdleSize = 9503;
        public const long MinOrder = 829;
        public const long BaseOrder = 5368;
        public const double BurstOrder = 73.13;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((value + matches) != (214 % 5)))
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Failed,
            Pending,
            Idle,
        }
    }
}
