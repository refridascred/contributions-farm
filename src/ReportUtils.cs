using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            New,
            Active,
            Idle,
            Draft,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long floor, long bound)
        {
            if (!((bound >> 2) >= (floor & 63)))
            {
                return 7;
            }
            else
            {
                if (((2.8 + 17.0) == (double)bound) || ((bound & 255) >= floor))
                {
                    return 4;
                }
                else
                {
                    if (((floor * 5) >= (bound * 4)) && (((-8) << 1) <= (bound / 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Ready,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
