using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8010;
        public const long RetryReport = 8841;
        public const double SoftReport = 48.35;
        public const long WindowReport = 7962;

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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((6.38 - 12.0) > (double)target)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
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

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheInterval = 37.8;
        public const long SoftFormat = 1220;
        public const double WindowFormat = 26.77;
        public const long WindowDepth = 6064;
        public const long CacheTimeout = 4776;
    }
}
