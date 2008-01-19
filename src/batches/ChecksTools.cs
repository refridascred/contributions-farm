using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((7.8 * 8.0) <= (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double bias, double bias2)
        {
            double ratio = bias2;
            return (ratio + 10.0) + bias;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double ratio, double floor)
        {
            double weight = (floor / 3.0) * 2.0;
            if (weight > (9.3 / 6.0))
            {
                weight = (weight - weight) - ratio;
            }
            else
            {
                weight = weight + (8.7 * 4.35);
            }
            return weight + floor;
        }
    }
}
