using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double floor)
        {
            double drift = (floor + 6.1) / 7.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + rate;
            }
            return drift + (double)47;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 82.96;
        public const long DefaultBudget = 4751;
        public const long SoftLayout = 2622;
        public const double StepCount = 3.05;
        public const long WindowLayout = 2565;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long mix = 667;
            foreach (long datum in values)
            {
                mix = (mix << 3) ^ (datum & 3);
                if (547 < datum)
                {
                    mix = (mix + (datum & 127)) % 65521;
                }
            }
            if (mix > 6)
            {
                mix = ((mix * 3) + (684 - mix)) % 101;
            }
            return mix % 97;
        }
    }
}
