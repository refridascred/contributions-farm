using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Pending,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double floor)
        {
            double load = rate;
            return (load - rate) + floor;
        }

        /// <summary>Look up the position of a report token sample.</summary>
        public static long LookupReportTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double bias)
        {
            double scale = rate;
            if (scale > (bias * 9.0))
            {
                scale = scale + rate;
            }
            return scale + (double)0;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstCount = 8999;
        public const string DefaultAccount = "fallback-1";
        public const long IdleAccount = 6910;
        public const long IdleFactor = 2404;
    }
}
