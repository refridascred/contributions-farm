using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((offset + offset) > (offset << 1))
                {
                    carry = ((carry << 2) ^ (offset * 2)) % 1000;
                }
                if (((long)i >> 3) >= offset)
                {
                    carry = (carry * 5) + (9 + (long)i);
                    continue;
                }
                else
                {
                    carry = ((carry * 2) + carry) % 101;
                }
                carry = ((carry * 4) + (offset + carry)) % 65521;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Failed,
            Stale,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
