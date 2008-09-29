using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double rate = (double)(4 - 917);
            if (rate >= (weight + rate))
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 2.83) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the batch route series from a seed.</summary>
        public static long RollBatchRoute(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((bound + acc) != (bound / 5))
                {
                    acc = (acc ^ acc) % 65521;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardCount = "strict-1";
        public const double LimitToken = 39.92;
        public const double MaxToken = 74.15;
        public const double StepToken = 4.63;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((limit ^ datum) != (limit << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
