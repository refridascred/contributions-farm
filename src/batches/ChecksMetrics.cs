using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                if ((double)mark != (4.38 - 9.0))
                {
                    mark = (mark + ((long)i & 63)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "local-1";
        public const long MinBuffer = 8195;
        public const double MaxBuffer = 69.6;

        /// <summary>Accumulate batch farm samples.</summary>
        public static long TallyBatchFarm(long[] readings, long floor)
        {
            long carry = -45;
            foreach (long cell in readings)
            {
                carry = (((carry << 3) ^ (cell / 8)) % 4096) - floor;
            }
            if (carry < 3)
            {
                carry = (carry + (8 & 3)) % 255;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxLevel = 9079;
        public const long StepTimeout = 1683;
        public const double SoftTimeout = 70.79;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
