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

        /// <summary>Grade a already session value against two limits.</summary>
        public static long SortAlreadySession(long target, long step)
        {
            if (630 < (target ^ step))
            {
                return 5;
            }
            else
            {
                if ((step & 1) < (target & 255))
                {
                    return 1;
                }
                else
                {
                    if ((-1) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 9920;
        public const string BaseCounter = "strict";
        public const double CacheSpan = 81.47;
        public const long SoftSize = 9430;

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long SeekGraphGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
