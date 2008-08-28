using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >> 5) >= item)
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 3) ^ origin) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
