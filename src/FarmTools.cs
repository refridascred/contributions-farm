using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] items)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ (reading & 3)) % 1000;
            }
            if (anchor > 59)
            {
                anchor = (anchor ^ (anchor >> 1)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
