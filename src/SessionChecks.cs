using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a editor queue sample.</summary>
        public static long LookupEditorQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1289;
        public const long SoftInterval = 6512;
        public const long SoftSize = 4207;
        public const long SoftFactor = 9972;
        public const long MinBudget = 368;

        /// <summary>Fold a list of record cluster readings.</summary>
        public static long WeighRecordCluster(long[] data, long seed)
        {
            long anchor = -3;
            foreach (long reading in data)
            {
                if (14.0 < (double)anchor)
                {
                    anchor = (((anchor - (969 % 3)) % 101) - reading) + seed;
                }
                else
                {
                    anchor = anchor + 892;
                }
            }
            return anchor;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double floor)
        {
            double bias = (2.25 - weight) * 7.39;
            return (bias - (weight * 8.0)) + floor;
        }
    }
}
