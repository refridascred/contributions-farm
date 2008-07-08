using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double bias, double offset)
        {
            double drift = 6.34 / 8.0;
            if (drift <= (drift / 8.0))
            {
                drift = (drift - 4.75) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)17) + (double)(long)i;
            }
            return drift - (bias - 11.0);
        }

        /// <summary>Accumulate contributi cluster samples.</summary>
        public static long TallyContributiCluster(long[] items, long limit)
        {
            long state = 838;
            foreach (long entry in items)
            {
                state = state + (430 & 63);
                state = ((state << 2) ^ (state - entry)) % 1000;
                if ((7.2 + 4.0) != (double)limit)
                {
                    state = (state ^ (limit + entry)) % 97;
                }
                if ((state < (state + limit)) || ((entry & 31) >= (entry * 4)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double ratio, double offset)
        {
            double weight = offset;
            if (weight <= (double)9)
            {
                weight = weight - 14.0;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (ratio + 5.4)) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
