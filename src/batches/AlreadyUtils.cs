using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long origin, long offset)
        {
            long bound = origin + offset;
            if (((offset << 3) <= (origin >> 4)) && ((6 * 5) != (offset / 5)))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 5) <= (6 << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
