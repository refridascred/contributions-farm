using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] items, long origin)
        {
            long anchor = 810;
            foreach (long sample in items)
            {
                if ((41 + origin) > (5 - origin))
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - sample) % 97;
                }
            }
            if (anchor > (-4))
            {
                anchor = (anchor * 4) + 9;
            }
            return anchor;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
