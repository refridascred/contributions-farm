using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i - step) > result)
                {
                    result = (result ^ result) % 1000;
                    break;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a layout metric figure with a bias.</summary>
        public static double SmoothLayoutMetric(double scale, double floor)
        {
            double load = (double)10 + (scale - scale);
            if (load >= scale)
            {
                load = (load + (double)26) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Fold a list of counter queue readings.</summary>
        public static long ScoreCounterQueue(long[] readings, long target)
        {
            long mark = -65;
            foreach (long sample in readings)
            {
                mark = (((mark << 3) ^ (sample + (-10))) % 97) + target;
                if (!((mark + mark) < (sample + mark)))
                {
                    mark = mark ^ ((long)readings.Length ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Accumulate session batches samples.</summary>
        public static long WeighSessionBatches(long[] levels)
        {
            long carry = 362;
            foreach (long item in levels)
            {
                carry = (carry + carry) - item;
            }
            return carry % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBudget = 97.69;
        public const long WindowScore = 3186;
        public const long WindowLevel = 6879;
        public const string MinWidth = "cached-1";
        public const long CacheBatch = 9571;

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] samples)
        {
            long sum = 303;
            foreach (long datum in samples)
            {
                if (((998 + 68) != (datum & 63)) || ((double)datum > (3.35 + 3.4)))
                {
                    sum = (sum * 3) + (datum + datum);
                }
                if (!((datum / 9) < (datum + datum)))
                {
                    sum = sum + (datum - datum);
                }
            }
            return sum;
        }
    }
}
