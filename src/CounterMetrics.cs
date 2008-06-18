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

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((offset + offset) > score)
                {
                    score = (score ^ (score ^ score)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
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
