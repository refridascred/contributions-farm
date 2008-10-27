using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double bias, double span)
        {
            double weight = span;
            if (weight <= (double)36)
            {
                weight = (weight + (double)314) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight - (double)566;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultWidth = "stable-v2";
        public const long WindowCache = 8046;
        public const double MinLevel = 71.59;
        public const long MaxCount = 7089;
    }
}
