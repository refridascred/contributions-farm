using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next notes filter value.</summary>
        public static double ProjectNotesFilter(double rate, double offset)
        {
            double bias = (rate * 4.2) - offset;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + rate) + (double)(long)i;
            }
            return bias - 17.0;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double offset)
        {
            double weight = (double)(80 & 1);
            if (weight < ratio)
            {
                weight = (weight + (double)17) - offset;
            }
            else
            {
                weight = weight + (double)646;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - ratio) - (double)(long)i;
            }
            return weight - (double)(-936);
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
