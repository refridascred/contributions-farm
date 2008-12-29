using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit tools contributi readings against a rule.</summary>
        public static long MeasureToolsContributiHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (7.0 <= (double)bound)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchRatio = 574;
        public const long BurstBudget = 8460;
        public const long HardNotes = 7318;
        public const long DefaultRatio = 2792;
        public const string BatchNotes = "latest";

        /// <summary>Scale a metric buffer figure with a bias.</summary>
        public static double ScaleMetricBuffer(double scale, double offset)
        {
            double rate = scale / 5.0;
            return rate - (offset * 0.9);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultLevel = "legacy-1";
        public const long StepBuffer = 8754;
        public const long LimitBuffer = 4370;
        public const long MinBuffer = 3582;
        public const long WindowWidth = 224;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
