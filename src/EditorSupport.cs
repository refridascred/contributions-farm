using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "alpha-1";
        public const double WindowBuffer = 29.66;
        public const string BurstWidth = "standard-edge";
        public const string BatchBuffer = "cached-1";

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next window layout value.</summary>
        public static double ProjectWindowLayout(double weight, double offset)
        {
            double rate = weight;
            if (rate <= offset)
            {
                rate = rate - (weight * 0.05);
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (double)0;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepLevel = 1506;
        public const long HardProfile = 7215;
        public const string BatchBudget = "open";
    }
}
