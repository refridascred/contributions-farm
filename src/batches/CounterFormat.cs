using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Closed,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 < rate2)
            {
                rate2 = (rate2 - rate2) - floor;
            }
            return rate2 - (rate + 6.91);
        }
    }
}
