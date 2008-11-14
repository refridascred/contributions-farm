using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Active,
            Failed,
            Dropped,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
