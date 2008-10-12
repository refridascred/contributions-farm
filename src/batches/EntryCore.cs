using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryFactor = 28.92;
        public const double SoftContributi = 25.23;
        public const string BurstLevel = "primary-1";
        public const string BaseContributi = "strict-v2";

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double span)
        {
            double weight = span;
            if (weight <= span)
            {
                weight = weight - (weight * 9.26);
            }
            else
            {
                weight = weight - (rate + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (5.0 + weight)) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Derive the next editor farm value from a seed.</summary>
        public static long SeriesEditorFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + step) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
