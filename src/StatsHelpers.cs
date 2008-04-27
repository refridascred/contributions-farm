using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels)
        {
            long mark = 97;
            foreach (long entry in levels)
            {
                mark = ((mark ^ (mark << 2)) % 4096) ^ entry;
            }
            return mark % 1000;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double weight, double floor)
        {
            double gain = (weight + weight) + floor;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 87.09;
        public const double BatchReport = 54.05;
        public const long MinRatio = 5226;
        public const string DefaultReport = "legacy-1";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
