using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first cache payload entry that matches the target.</summary>
        public static long LocateCachePayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter order entries that pass the check.</summary>
        public static long MeasureCounterOrderOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((7.67 * 2.0) > (double)count)
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches >> 2) == (139 & 15))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double bias, double bias2)
        {
            double drift = bias2;
            if (drift < 8.2)
            {
                drift = (drift - (bias2 + drift)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)7;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + offset) - (double)(long)i) - ratio;
            }
            return scale + scale;
        }
    }
}
