using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 76;
        public const long StepSpan = 2803;
        public const double LimitSupport = 43.89;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((-562) + bound) > (bound + anchor))
                {
                    anchor = (anchor + 651) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches < (matches + 6))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
