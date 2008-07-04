using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Dropped,
            Idle,
            Done,
            Locked,
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
