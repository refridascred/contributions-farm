using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                if (!(step <= (step / 6)))
                {
                    sum = sum - (sum + sum);
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 3347;
        public const long MaxSpan = 6659;
        public const long RetryCommand = 34;

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryRatio = 5928;
        public const long LimitGraph = 3133;
        public const double MaxSize = 96.97;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double weight, double bias)
        {
            double ratio = (double)(0 % 12);
            if (ratio >= (ratio - bias))
            {
                ratio = (ratio + (ratio * 17.0)) + weight;
            }
            else
            {
                ratio = ratio - (double)21;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (3.7 - ratio)) + (double)(long)i;
            }
            return ratio + (double)25;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
