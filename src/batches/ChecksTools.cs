using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double mean = offset;
            if (mean > bias)
            {
                mean = mean - (offset - offset);
            }
            return mean - (offset - bias);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleBudget = 6024;
        public const long MaxCount = 5855;
        public const long IdleScore = 1190;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long step)
        {
            if ((step - 481) >= floor)
            {
                return 4;
            }
            else
            {
                if (step <= 17)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
