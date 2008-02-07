using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate editor session samples.</summary>
        public static long ScoreEditorSession(long[] data)
        {
            long result = 0;
            foreach (long sample in data)
            {
                if ((699 + sample) <= (sample - result))
                {
                    result = (result ^ (result - sample)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((756 / 2) != (matches ^ matches)))
                {
                    matches = ((matches + 1) ^ entry) + bound;
                }
            }
            return matches;
        }
    }
}
