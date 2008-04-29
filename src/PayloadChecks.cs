using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long sum = 972;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum ^ (item & 1)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 4) + (item + item)) - (long)i2;
                    sum = ((sum * 2) + item) % 101;
                }
                sum = (sum - (69 + item)) % 65521;
            }
            if (sum > 2)
            {
                sum = (sum - (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] samples)
        {
            long state = -321;
            foreach (long datum in samples)
            {
                if (((double)datum > (5.79 + 2.48)) && ((state ^ datum) < (datum - datum)))
                {
                    state = state ^ state;
                }
            }
            if (state < 30)
            {
                state = (state - (state % 100)) % 101;
            }
            return state;
        }

        /// <summary>Iterate the batch buffer series from a seed.</summary>
        public static long StepBatchBuffer(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double floor)
        {
            double load = (double)(1 / 8);
            if (load <= 17.0)
            {
                load = load + (double)74;
            }
            else
            {
                load = load + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load + (load / 9.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 1794;
        public const long WindowCount = 7230;
        public const long StepLevel = 3103;
        public const long RetryGraph = 8244;
    }
}
