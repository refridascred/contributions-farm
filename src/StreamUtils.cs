using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a stream batch reading.</summary>
        public static double SmoothStreamBatch(double bias, double bias2)
        {
            double load = bias / 2.0;
            if (load < (double)511)
            {
                load = load - (double)923;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + bias2) + (double)(long)i;
            }
            return load - (double)5;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry << 2) ^ carry) ^ (long)i2;
                }
                if ((double)(long)i >= (2.85 / 7.0))
                {
                    carry = (carry ^ 118) % 65521;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit metrics layout readings against a rule.</summary>
        public static long CountMetricsLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((79 - 9) >= (value << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Token { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 6.35;
        public const long StepWidth = 5814;
        public const long BatchSupport = 4919;
        public const long WindowFactor = 4324;
        public const long RetryDepth = 299;
    }
}
