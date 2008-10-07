using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up contributi context samples.</summary>
        public static long OverlapContributiContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseSize = 36.36;
        public const long BurstRecord = 3045;
        public const long WindowRecord = 5997;
        public const string BurstInterval = "primary-1";
        public const long BaseRecord = 7189;

        /// <summary>Match up command cluster samples.</summary>
        public static long CompareCommandClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
