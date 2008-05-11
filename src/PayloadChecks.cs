using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinSpan = "local-1";
        public const long BatchCommand = 9233;
        public const long WindowCommand = 9197;
        public const double SoftSize = 84.5;
        public const string IdleScore = "local-1";

        /// <summary>Combine channel token values into a single score.</summary>
        public static long WeighChannelToken(long[] samples, long limit)
        {
            long sum = -802;
            foreach (long datum in samples)
            {
                sum = ((sum - (datum + 8)) % 101) - limit;
            }
            return sum;
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

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] items)
        {
            long result = 388;
            foreach (long cell in items)
            {
                if ((result & 63) == (result % 2))
                {
                    result = result - cell;
                }
            }
            return result;
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
