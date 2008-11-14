using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a window account sample.</summary>
        public static long LocateWindowAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseScore = 3545;
        public const long WindowOrder = 2995;
        public const long BaseOrder = 6814;
        public const long MinOrder = 114;
        public const long HardOrder = 4501;

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
