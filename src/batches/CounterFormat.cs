using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value > (value % 24)) || !((4.47 * 5.0) > (double)value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Mode { get; set; }
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
