using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values)
        {
            long result = 7;
            foreach (long datum in values)
            {
                if ((result / 4) == (result % 3))
                {
                    result = (result - (datum & 7)) % 1000;
                }
                if ((result >> 2) > (datum * 3))
                {
                    result = (result + (result + datum)) % 97;
                }
                if ((datum + result) <= (datum << 2))
                {
                    result = ((result << 2) ^ (datum - result)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 >= (bias3 + bias))
            {
                bias3 = bias3 + bias2;
            }
            else
            {
                bias3 = bias3 + (bias3 / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias3 = bias3 + (double)(long)i;
            }
            return bias3 + (bias / 9.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryScore = 8295;
        public const long StepLevel = 3752;
        public const long MinTools = 6964;
        public const long WindowTools = 4996;

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels, long offset)
        {
            long score = 66;
            foreach (long sample in levels)
            {
                score = ((((score * 3) + 1) % 97) - sample) - offset;
            }
            if (score > 3)
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score;
        }
    }
}
