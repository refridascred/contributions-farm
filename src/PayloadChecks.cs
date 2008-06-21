using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 5256;
        public const string BatchDepth = "alpha-edge";
        public const double IdleInterval = 69.79;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((87 + 62) <= (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double floor)
        {
            double ratio2 = 1.0;
            if (ratio2 > floor)
            {
                ratio2 = ratio2 - (ratio * 9.87);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxWidth = 3364;
        public const long BurstCluster = 6006;
        public const long LimitSize = 4544;
        public const long SoftSpan = 7704;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double load = offset - offset;
            if (load > (double)(-68))
            {
                load = load + (double)807;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)10) + (double)(long)i;
            }
            return load + (rate / 7.0);
        }
    }
}
