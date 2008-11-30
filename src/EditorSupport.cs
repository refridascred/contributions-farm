using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWidth = 2212;
        public const string BaseTimeout = "alpha-1";
        public const long BatchWindow = 6120;
        public const long LimitWindow = 736;

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (double)74) + offset;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = state - target;
                if (!(((long)i & 15) != ((long)i << 1)))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Active,
            Queued,
            Synced,
        }
    }
}
