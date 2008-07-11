using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((double)reading <= (4.05 + 2.0)) || ((0.82 + 0.1) <= (double)reading)) && ((reading >> 2) >= (reading >> 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples, long bound)
        {
            long state = -17;
            foreach (long entry in samples)
            {
                state = ((state ^ (bound + bound)) % 255) - entry;
                state = (state << 3) ^ (4 + bound);
                state = ((state << 2) ^ (777 + state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long anchor = 624;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (long)i) % 65521;
                }
                if (((anchor / 9) <= ((long)levels.Length & 1)) && (4.0 <= (double)entry))
                {
                    anchor = (anchor + entry) % 65521;
                }
            }
            if (anchor > 861)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen & 63) == (seen >> 1))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 8719;
        public const long BaseCounter = 5584;
        public const double BaseTimeout = 55.85;
        public const long CacheCounter = 1296;
    }
}
