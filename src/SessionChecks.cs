using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Check that every cluster notes entry stays within the limit.</summary>
        public static bool GuardClusterNotesRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchWidth = "latest-v2";
        public const string DefaultQueue = "staging-edge";
        public const long MaxQueue = 8456;
        public const long MinQueue = 6840;
    }
}
