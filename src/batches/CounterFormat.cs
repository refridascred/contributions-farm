using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long step2)
        {
            long next = step + step2;
            if (((0 >> 3) > step2) && (next > step2))
            {
                return 1;
            }
            else
            {
                if ((step2 - next) >= (step2 + step2))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double bias)
        {
            double load = scale - 7.3;
            return (load + (scale + scale)) + bias;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
