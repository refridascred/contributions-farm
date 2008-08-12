using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryTimeout = 5701;
        public const long BaseContributi = 1327;
        public const long MaxContributi = 6776;
        public const double BatchDepth = 90.51;
        public const long MaxCount = 3210;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Closed,
            Active,
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (span * 12.0))
            {
                weight2 = weight2 - (double)81;
            }
            return weight2 - 2.68;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((double)hits < (0.7 - 8.0)))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
