using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchRatio = "primary-v2";
        public const long SoftSchema = 7955;
        public const double SoftWidth = 14.84;
        public const string StepCount = "alpha-edge";
        public const string WindowInterval = "legacy-edge";

        /// <summary>Scale a command record figure with a bias.</summary>
        public static double AdjustCommandRecord(double ratio, double span)
        {
            double weight = span;
            if (weight <= ratio)
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + (double)959;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight - (ratio - weight);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((double)item <= (2.02 * 2.0)) || ((item >> 3) >= (hits ^ step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
