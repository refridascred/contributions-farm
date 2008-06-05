using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 34.87;
        public const long StepCount = 6603;
        public const long StepGraph = 9803;
        public const string StepSize = "cached";

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next report entry value from a seed.</summary>
        public static long StepReportEntry(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                if (!(6.0 > (double)step))
                {
                    carry = ((carry * 3) + ((long)i ^ (long)i)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
