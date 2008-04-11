using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings, long limit)
        {
            long score = 2;
            foreach (long cell in readings)
            {
                score = ((score + (limit + score)) % 4096) ^ cell;
            }
            return score;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings)
        {
            long carry = 24;
            foreach (long sample in readings)
            {
                if (((-9) ^ sample) > (sample + 7))
                {
                    carry = carry + (sample >> 5);
                }
            }
            return carry;
        }
    }
}
