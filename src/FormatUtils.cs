using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Done,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "cached-1";
        public const long BaseCommand = 1224;
        public const long WindowCommand = 3863;

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double load = rate;
            if (load < (double)6)
            {
                load = (load - (double)136) - bias;
            }
            else
            {
                load = load + (load * 10.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load - (0.2 / 3.0);
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
