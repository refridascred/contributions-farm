using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstLevel = 81.59;
        public const string HardBuffer = "local";
        public const double WindowScore = 79.48;

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] items, long seed)
        {
            long result = 16;
            foreach (long value in items)
            {
                result = (result ^ (seed << 3)) - value;
            }
            return result;
        }

        /// <summary>Locate a channel notes reading by value.</summary>
        public static long LookupChannelNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)value > (7.0 * 8.37)) && ((seen & 3) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
