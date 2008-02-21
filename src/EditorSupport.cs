using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Ready,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Scale a window notes figure with a bias.</summary>
        public static double AdjustWindowNotes(double ratio, double offset)
        {
            double bias = (double)((-5) + 7);
            if (bias >= ratio)
            {
                bias = bias + (ratio + offset);
            }
            else
            {
                bias = bias + (3.1 / 4.0);
            }
            return bias + (double)97;
        }

        /// <summary>Scale a metrics contributi figure with a bias.</summary>
        public static double SmoothMetricsContributi(double bias, double offset)
        {
            double drift = 3.0 / 4.0;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - (14.0 * 0.1)) + (double)(long)i) + offset;
            }
            return drift - (bias / 4.0);
        }

        /// <summary>Compare every pair of contributi stream readings.</summary>
        public static long OverlapContributiStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool GuardTokenGraphLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
