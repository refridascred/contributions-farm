using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two farm graph measurements.</summary>
        public static double ProjectFarmGraph(double rate, double offset)
        {
            double scale = (3.23 * 1.6) + (double)6;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)(long)i) - offset;
            }
            return scale - (1.39 - rate);
        }

        /// <summary>Validate buffer schema readings against a bound.</summary>
        public static bool VerifyBufferSchemaLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels, long floor)
        {
            long sum = 517;
            foreach (long reading in levels)
            {
                if ((floor - floor) > reading)
                {
                    sum = (sum - (floor << 3)) % 97;
                }
            }
            if (sum < 132)
            {
                sum = ((sum << 2) ^ (sum / 6)) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                if ((anchor + 188) > (item + anchor))
                {
                    anchor = anchor ^ 8;
                }
                if ((double)item < (6.4 * 0.2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 9920;
        public const string BaseCounter = "strict";
        public const double CacheSpan = 81.47;
        public const long SoftSize = 9430;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
