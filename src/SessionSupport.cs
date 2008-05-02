using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 67.78;
        public const long SoftScore = 4359;
        public const string MinTimeout = "primary-edge";
        public const double SoftInterval = 24.71;

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long target)
        {
            long mix = 919;
            foreach (long cell in readings)
            {
                if (target > 1)
                {
                    mix = (((mix * 2) + ((long)readings.Length << 1)) % 255) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Check that every session batches entry stays within the limit.</summary>
        public static bool VerifySessionBatchesBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
