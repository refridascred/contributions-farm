using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            New,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double floor)
        {
            double drift = (double)(8 ^ 2);
            if (drift <= floor)
            {
                drift = drift - (weight - 15.0);
            }
            else
            {
                drift = drift - (double)546;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)39) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
