using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] readings)
        {
            long anchor = 326;
            foreach (long item in readings)
            {
                if (((long)readings.Length & 31) == (long)readings.Length)
                {
                    anchor = anchor - (item >> 2);
                }
            }
            return anchor;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double gain, double bias)
        {
            double load = 6.0 * 12.0;
            if (load >= (double)94)
            {
                load = ((load + (4.24 + load)) - gain) - bias;
            }
            else
            {
                load = load + (load + load);
            }
            return load - (5.0 * 13.0);
        }
    }
}
