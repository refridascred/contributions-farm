using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Dropped,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double rate, double bias)
        {
            double mean = (double)850 + 6.0;
            if (mean > bias)
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + (rate * 1.2);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean + (double)8;
        }
    }
}
