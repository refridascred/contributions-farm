using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i > (13 - 24))
                {
                    break;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc ^ (7 / 7)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Flag { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item + item) >= (hits + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two metric filter measurements.</summary>
        public static double ScaleMetricFilter(double bias, double floor)
        {
            double mean = (double)(852 + (-658));
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - floor) - (double)(long)i) - bias;
            }
            return mean + (double)49;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 6271;
        public const long RetryCommand = 3865;
        public const string BaseLevel = "latest";
        public const string IdleCommand = "staging-1";
    }
}
