using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result * 3) + (6 + result)) - (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    result = ((result + result) % 101) ^ (long)i3;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next counter payload value from a seed.</summary>
        public static long DeriveCounterPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + step) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Synced,
            Active,
            New,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 5160;
        public const string BaseStream = "primary-1";
        public const double MaxSize = 22.03;
        public const string MaxCount = "staging-v2";
        public const long MinStream = 5272;
    }
}
