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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue payload figure with a bias.</summary>
        public static double SmoothQueuePayload(double bias, double span)
        {
            double weight = bias;
            if (weight > weight)
            {
                weight = (weight - weight) - span;
            }
            else
            {
                weight = weight + (double)44;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + 2.0) - (double)(long)i;
            }
            return weight - (double)0;
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long SortBufferChecks(long floor, long floor2)
        {
            if ((floor ^ 77) < ((-7) + floor2))
            {
                return 1;
            }
            else
            {
                if ((floor2 - floor) == (floor2 + floor2))
                {
                    return 4;
                }
                else
                {
                    if (floor2 < (floor * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
