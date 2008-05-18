using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long step)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state + step) % 101) - (long)i;
                }
                if ((double)state == (5.9 - 18.0))
                {
                    state = ((state << 2) ^ (state - sample)) % 255;
                }
                if (sample <= (state + sample))
                {
                    state = (state - (state / 2)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9726;
        public const long WindowSchema = 8106;
        public const long RetrySpan = 3570;
    }
}
