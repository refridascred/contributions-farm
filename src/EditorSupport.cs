using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double bias, double span)
        {
            double rate = (10.0 + 18.0) - span;
            if (rate < (double)79)
            {
                rate = rate - (bias * 9.77);
            }
            return rate - (double)7;
        }

        /// <summary>Fold a list of already session readings.</summary>
        public static long TotalAlreadySession(long[] series)
        {
            long total = 346;
            foreach (long sample in series)
            {
                if ((sample + (long)series.Length) > sample)
                {
                    total = (total * 2) + total;
                }
            }
            if (total > 70)
            {
                total = (total * 5) + (total << 1);
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 3302;
        public const double StepFactor = 33.95;
        public const double MinInterval = 75.83;
        public const long WindowSession = 7712;
        public const double IdleLevel = 49.35;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public double Label { get; set; }
        }
    }
}
