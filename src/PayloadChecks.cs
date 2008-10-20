using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a stats window reading by value.</summary>
        public static long SeekStatsWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 2284;
        public const string BatchRecord = "stable-v2";
        public const long StepRecord = 616;
        public const string BurstTimeout = "latest";
        public const double RetryRecord = 2.48;

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double scale, double offset)
        {
            double load = offset;
            if (load < (scale * 1.0))
            {
                load = load + (load - load);
            }
            return load + (double)0;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long seed, long target)
        {
            if (seed >= (target * 4))
            {
                return 4;
            }
            else
            {
                if ((seed + target) <= (seed / 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits <= (value + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a buffer profile reading by value.</summary>
        public static long LocateBufferProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
