using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate context payload readings against a bound.</summary>
        public static bool GuardContextPayloadRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double mean = (double)(8 ^ 39);
            if (mean > mean)
            {
                mean = mean + (mean + mean);
            }
            else
            {
                mean = mean + (6.7 - offset);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinInterval = 2792;
        public const long SoftGraph = 3796;
        public const string MinScore = "cached-v2";
        public const double CacheGraph = 61.93;

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 2960;
        public const long CacheSize = 6957;
        public const double LimitCommand = 1.08;
        public const long HardTimeout = 2928;
        public const double BurstCommand = 48.0;

        /// <summary>Find the first entry batch entry that matches the target.</summary>
        public static long LocateEntryBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
