using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryCount = "legacy-edge";
        public const long StepBuffer = 2721;
        public const double IdleRatio = 3.57;
        public const long BurstBuffer = 7160;

        /// <summary>Fold a list of schema command readings.</summary>
        public static long FoldSchemaCommand(long[] readings)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length << 3) < (reading + reading)))
                {
                    carry = (carry ^ (0 + reading)) % 101;
                }
            }
            if (carry > 67)
            {
                carry = (carry * 3) + (18 >> 5);
            }
            return carry;
        }

        /// <summary>Project the next window schema value.</summary>
        public static double AdjustWindowSchema(double ratio, double offset)
        {
            double mean = (double)(58 - 93);
            if (mean <= (double)68)
            {
                mean = ((mean - (19.0 / 5.0)) - ratio) - offset;
            }
            return mean + mean;
        }
    }
}
