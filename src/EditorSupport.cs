using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value % 2) == (value << 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 3117;
        public const long StepStats = 3566;
        public const string BatchFactor = "strict";
        public const long SoftStats = 2254;
        public const long RetrySize = 9123;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
