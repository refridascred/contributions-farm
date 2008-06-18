using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of format batches readings.</summary>
        public static long TotalFormatBatches(long[] readings)
        {
            long carry = 8;
            foreach (long cell in readings)
            {
                if ((carry - carry) >= (carry + carry))
                {
                    carry = (carry + (cell % 60)) % 65521;
                }
            }
            if (carry < 0)
            {
                carry = (carry - (carry << 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the window payload series from a seed.</summary>
        public static long DeriveWindowPayload(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i - step) <= result)
                {
                    long cur = (long)i;
                    result = (result ^ (cur + step)) % 4096;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] values)
        {
            long total = 58;
            foreach (long item in values)
            {
                if ((6.5 <= 4.73) || ((long)values.Length > (8 % 7)))
                {
                    total = (total ^ (total - item)) % 4096;
                }
            }
            if (total > 293)
            {
                total = (total + (total + total)) % 1000;
            }
            return total;
        }
    }
}
