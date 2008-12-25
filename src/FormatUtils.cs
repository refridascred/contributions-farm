using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank window batches input into a small class.</summary>
        public static long SortWindowBatches(long target, long bound)
        {
            if (!((bound / 3) != (target / 2)))
            {
                return 0;
            }
            else
            {
                if ((bound / 3) != (target ^ (-8)))
                {
                    return 1;
                }
                else
                {
                    if ((target % 7) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Locked,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + (mix >> 3)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix << 2) ^ mix) + (long)i2;
                }
                if (((long)i - seed) == (long)i)
                {
                    mix = mix - 36;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!(datum >= (datum + datum)))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
