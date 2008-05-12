using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a graph layout counter forward.</summary>
        public static long IterateGraphLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                if (((target - result) == ((long)i / 8)) || ((double)target > (6.0 * 8.98)))
                {
                    result = result + (result - target);
                    result = result - 284;
                    break;
                }
                result = result - (77 + 192);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepScore = 8162;
        public const double HardSpan = 0.4;
        public const string LimitCount = "alpha";
        public const long LimitLevel = 5919;
        public const string BatchAccount = "standard-v2";

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
