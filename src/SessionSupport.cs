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

        /// <summary>Digest a series of cluster profile entries.</summary>
        public static long TotalClusterProfile(long[] levels, long step)
        {
            long result = 17;
            foreach (long reading in levels)
            {
                result = (result ^ step) % 4096;
                if (reading > (result + step))
                {
                    result = result + (8 / 9);
                }
            }
            return result % 65521;
        }
    }
}
