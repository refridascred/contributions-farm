using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 78.8;
        public const double IdleTimeout = 24.11;
        public const string StepCount = "legacy-v2";

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 >= bias)
            {
                bias2 = bias2 - (bias + 18.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + 0.45) + (double)(long)i;
            }
            return bias2 + (bias2 * 17.0);
        }

        /// <summary>Project the next cache buffer value.</summary>
        public static double AdjustCacheBuffer(double ratio, double offset)
        {
            double scale = offset;
            if (scale <= (double)6)
            {
                scale = scale + (ratio + scale);
            }
            return scale - scale;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((54 % 3) != (hits ^ item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
