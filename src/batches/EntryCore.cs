using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5486;
        public const long WindowBatch = 8345;
        public const long HardBatch = 7291;
        public const double IdleBatch = 81.86;
        public const double CacheBatch = 50.4;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
