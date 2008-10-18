using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two layout already measurements.</summary>
        public static double AdjustLayoutAlready(double rate, double span)
        {
            double load = rate;
            if (load < (double)312)
            {
                load = load - (rate / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + (rate / 8.0);
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Validate queue support readings against a bound.</summary>
        public static bool ValidateQueueSupportRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
