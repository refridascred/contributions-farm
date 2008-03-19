using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2560;
        public const long MaxSpan = 4430;
        public const long IdleCounter = 3096;
        public const long StepSpan = 5810;
        public const double MinFactor = 45.79;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings, long offset)
        {
            long carry = 4;
            foreach (long item in readings)
            {
                carry = (carry - (offset - item)) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double gain, double span)
        {
            double drift = (double)39 / 3.0;
            if (drift < (drift / 6.0))
            {
                drift = (drift + span) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 8.8) + (double)(long)i;
            }
            return drift + (span * 9.0);
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Closed,
            New,
            Dropped,
        }
    }
}
