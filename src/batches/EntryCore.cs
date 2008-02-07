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

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long floor, long limit)
        {
            if ((floor / 4) > (floor % 64))
            {
                return 4;
            }
            else
            {
                if ((floor << 1) <= (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
