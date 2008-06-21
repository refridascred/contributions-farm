using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels, long offset)
        {
            long mark = 31;
            foreach (long sample in levels)
            {
                if ((sample - 30) <= offset)
                {
                    mark = ((mark * 4) + ((-59) ^ sample)) % 4096;
                }
            }
            if (mark < (-58))
            {
                mark = ((mark * 5) + mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
