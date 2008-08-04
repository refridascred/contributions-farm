using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Draft,
            Paused,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double drift = 2.9 / 6.0;
            if (drift <= (9.1 * 7.45))
            {
                drift = ((drift + drift) + rate) + offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + drift;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
