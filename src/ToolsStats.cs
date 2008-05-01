using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count * 4) < (entry / 6))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultSize = 3671;
        public const double BatchCounter = 96.5;
        public const string DefaultCounter = "latest";
    }
}
