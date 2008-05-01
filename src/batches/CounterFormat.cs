using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepBudget = 9815;
        public const long SoftSpan = 2140;
        public const string IdleAlready = "legacy";
        public const long MaxScore = 272;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
