using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double rate, double bias)
        {
            double ratio = (double)400 + (double)3;
            if (ratio > (double)1)
            {
                ratio = (ratio + rate) - bias;
            }
            return ratio - 0.57;
        }

        /// <summary>Validate buffer record readings against a bound.</summary>
        public static bool CheckBufferRecordRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data)
        {
            long acc = -66;
            foreach (long cell in data)
            {
                if ((60 - cell) > (cell + cell))
                {
                    acc = acc ^ (cell - acc);
                    acc = (acc - (cell + acc)) % 97;
                    continue;
                }
                else
                {
                    long bound = cell - 943;
                    acc = (acc - (bound + 9)) % 255;
                }
                if ((acc - cell) <= acc)
                {
                    continue;
                }
                if (2 >= cell)
                {
                    acc = (acc + cell) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultCount = 9043;
        public const long LimitRatio = 628;
        public const string BatchSpan = "stable";
    }
}
