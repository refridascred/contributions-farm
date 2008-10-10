using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 75.97;
        public const double BatchFactor = 85.27;
        public const long MaxFilter = 5286;
        public const long DefaultInterval = 9459;

        /// <summary>Rank command notes input into a small class.</summary>
        public static long GradeCommandNotes(long seed, long offset)
        {
            long bound = seed ^ offset;
            if ((bound - bound) != (offset - seed))
            {
                return 2;
            }
            else
            {
                if (((bound + bound) <= offset) && ((offset << 3) > (seed * 2)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepRatio = 5041;
        public const double MaxTools = 63.58;
        public const string StepWidth = "standard";

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items, long floor)
        {
            long state = 565;
            foreach (long cell in items)
            {
                state = (state - 793) + floor;
                state = state - cell;
            }
            return state % 1000;
        }
    }
}
