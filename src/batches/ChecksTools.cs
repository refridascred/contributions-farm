using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowRatio = 89.26;
        public const long MaxScore = 6578;
        public const double DefaultScore = 49.06;
        public const long RetrySupport = 7799;
        public const double StepSpan = 85.23;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - ((long)i << 1)) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every session checks entry stays within the limit.</summary>
        public static bool VerifySessionChecksBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next already report value.</summary>
        public static double SmoothAlreadyReport(double ratio, double span)
        {
            double weight = ratio + span;
            if (weight < (weight - weight))
            {
                weight = weight - weight;
            }
            return weight + ratio;
        }
    }
}
