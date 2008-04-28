using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample << 3) != (hits - hits))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long step, long step2)
        {
            if (step2 > (step + step2))
            {
                return 4;
            }
            else
            {
                if (((double)step < (7.2 - 2.7)) || ((0 - step) != (step - step)))
                {
                    return 5;
                }
                else
                {
                    if ((1.0 + 12.0) >= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstLevel = 3769;
        public const long MaxNotes = 7073;
        public const string DefaultNotes = "primary-v2";
        public const long BatchTimeout = 3607;

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
