using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardRatio = "primary-edge";
        public const long DefaultInterval = 4643;
        public const long LimitLayout = 8965;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] series)
        {
            long total = 9;
            foreach (long value in series)
            {
                total = (total << 2) ^ (value << 1);
                if (((long)series.Length & 15) >= value)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a window entry figure with a bias.</summary>
        public static double SmoothWindowEntry(double weight, double bias)
        {
            double scale = bias;
            if (scale <= (double)1)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (weight - bias)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double rate, double floor)
        {
            double ratio = floor + (floor / 9.0);
            if (ratio < 17.0)
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (rate + 7.5)) + (double)(long)i;
            }
            return ratio + rate;
        }
    }
}
