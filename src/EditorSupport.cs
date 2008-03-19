using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double mean = 9.93;
            if (mean > (weight + weight))
            {
                mean = (mean - 5.0) - bias;
            }
            return mean + weight;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 5762;
        public const long SoftWindow = 3407;
        public const double IdleWidth = 55.09;
        public const long StepWindow = 9996;
        public const long IdleWindow = 8051;

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 97.18;
        public const long HardProfile = 6885;
        public const long DefaultBudget = 440;
        public const long MinLevel = 5233;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 < gain)
            {
                gain2 = (gain2 - (gain - gain2)) + span;
            }
            return gain2 - (double)870;
        }
    }
}
