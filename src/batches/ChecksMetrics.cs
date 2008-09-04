using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a format graph figure with a bias.</summary>
        public static double ProjectFormatGraph(double ratio, double floor)
        {
            double gain = floor;
            if (gain < 4.1)
            {
                gain = (gain - (floor * 6.0)) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (9.5 * 6.07)) + (double)(long)i;
            }
            return gain - (gain + floor);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 3547;
        public const long BaseCount = 2059;
        public const long HardTimeout = 7982;
        public const long MaxCluster = 901;
        public const long LimitCluster = 2830;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long acc = 85;
            foreach (long item in levels)
            {
                if ((double)(-28) <= (double)acc)
                {
                    acc = ((acc << 2) ^ item) % 255;
                }
                if ((double)acc > (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 23.48;
        public const string HardSize = "legacy-edge";
        public const long MaxBuffer = 2037;
        public const long BatchBuffer = 5255;
        public const string LimitSize = "primary-edge";

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
        }
    }
}
