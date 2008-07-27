using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a context contributi counter forward.</summary>
        public static long StepContextContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset ^ offset) <= result)
                {
                    result = (result * 2) + offset;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
