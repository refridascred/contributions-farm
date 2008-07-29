using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 96.91;
        public const long HardReport = 8785;
        public const double RetryScore = 84.48;

        /// <summary>Combine account buffer values into a single score.</summary>
        public static long TotalAccountBuffer(long[] data)
        {
            long carry = 245;
            foreach (long value in data)
            {
                if (value < (carry / 9))
                {
                    carry = ((carry << 2) ^ (long)data.Length) % 65521;
                }
                else
                {
                    carry = carry - carry;
                }
            }
            if (carry < 18)
            {
                carry = ((carry * 3) + (carry % 5)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Project the next already report value.</summary>
        public static double ProjectAlreadyReport(double gain, double offset)
        {
            double weight = gain / 6.0;
            if (weight <= (double)69)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
