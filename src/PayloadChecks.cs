using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next profile metric value.</summary>
        public static double ProjectProfileMetric(double ratio, double offset)
        {
            double weight = ratio;
            return (weight + ratio) + offset;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings)
        {
            long sum = 0;
            foreach (long datum in readings)
            {
                if ((double)sum > (19.0 + 10.0))
                {
                    sum = (((sum << 2) ^ (5 + sum)) % 97) + datum;
                }
            }
            if (sum > 334)
            {
                sum = (sum ^ (sum << 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8014;
        public const double WindowSpan = 32.41;
        public const long WindowChannel = 4564;
        public const string LimitInterval = "open-v2";

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (double)52)
            {
                weight2 = weight2 + (offset / 7.0);
            }
            else
            {
                weight2 = weight2 + (double)42;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - 0.1) + (double)(long)i;
            }
            return weight2 + (double)(-8);
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
