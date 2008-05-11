using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long carry = 0;
            foreach (long item in series)
            {
                carry = (carry + (item * 2)) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a window record reading.</summary>
        public static double AdjustWindowRecord(double ratio, double bias)
        {
            double weight = 6.5;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - (ratio / 5.0)) - (double)(long)i) - bias;
            }
            return weight - 0.3;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
