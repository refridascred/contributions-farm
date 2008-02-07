using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit route record readings against a rule.</summary>
        public static long CountRouteRecordOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length < (cell / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every cache layout entry stays within the limit.</summary>
        public static bool CheckCacheLayoutLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryRatio = 145;
        public const long SoftTimeout = 5788;
        public const long StepEditor = 8512;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long floor, long limit)
        {
            if ((double)81 > (double)floor)
            {
                return 2;
            }
            else
            {
                if ((limit > (floor ^ floor)) && ((limit * 3) < (limit % 12)))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 3) <= (floor + 767))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)floor <= 2.99))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
