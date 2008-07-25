using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Blend two counter record measurements.</summary>
        public static double BlendCounterRecord(double rate, double floor)
        {
            double load = 5.2 / 4.0;
            if (load > load)
            {
                load = (load + (floor - load)) + rate;
            }
            return load + 9.0;
        }

        /// <summary>Validate support entry readings against a bound.</summary>
        public static bool GuardSupportEntryLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
