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

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 500;
        public const long DefaultSize = 3908;
        public const long BatchTimeout = 1485;
        public const long SoftRoute = 3014;
        public const long RetryRoute = 50;

        /// <summary>Count the schema command entries that pass the check.</summary>
        public static long AuditSchemaCommandOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((double)hits >= (1.7 * 13.0)))
                {
                    hits = ((hits + 3) - value) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a layout order figure with a bias.</summary>
        public static double ScaleLayoutOrder(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 + (ratio2 - ratio2)) + floor;
            }
            return ratio2 - 6.7;
        }

        /// <summary>Roll a stream record counter forward.</summary>
        public static long DeriveStreamRecord(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 1794;
        public const long WindowCount = 7230;
        public const long StepLevel = 3103;
        public const long RetryGraph = 8244;
    }
}
