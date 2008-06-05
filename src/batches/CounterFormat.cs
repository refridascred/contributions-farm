using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Idle,
            Ready,
            Closed,
        }

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
