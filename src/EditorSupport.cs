using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix - (mix << 1)) % 97;
                mix = (mix + (mix + mix)) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 9197;
        public const double BaseLevel = 36.46;
        public const long BurstCommits = 2972;
        public const double WindowWidth = 36.28;

        /// <summary>Find the first schema payload entry that matches the target.</summary>
        public static long FindSchemaPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support payload readings against a bound.</summary>
        public static bool GuardSupportPayloadBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate queue window readings against a bound.</summary>
        public static bool CheckQueueWindowLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
