using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 52.16;
        public const long RetryScore = 1582;
        public const long BurstPayload = 8385;

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long floor)
        {
            long state = 6;
            foreach (long reading in levels)
            {
                state = (state + 9) + floor;
                state = (state - reading) % 65521;
            }
            return state;
        }

        /// <summary>Grade a window schema value against two limits.</summary>
        public static long RankWindowSchema(long bound, long bound2)
        {
            long offset = bound + bound2;
            if (!(bound <= (bound2 & 63)))
            {
                return 3;
            }
            else
            {
                if (((bound & 63) < (bound2 & 1)) && ((offset % 100) <= (0 ^ bound)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
