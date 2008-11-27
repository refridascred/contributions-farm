using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (floor <= 84)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)datum < (16.0 / 7.0)) && !((13.0 * 8.7) >= (double)(long)data.Length))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((52 - result) > (floor + result))
                {
                    result = ((result * 2) + (floor << 1)) % 97;
                    result = result ^ (floor * 3);
                    break;
                }
                else
                {
                    result = (result + (result + result)) % 65521;
                    result = (result << 3) ^ floor;
                }
                if ((19.0 * 2.2) > (double)floor)
                {
                    result = ((result * 5) + ((long)i >> 3)) % 65521;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 1949;
        public const long RetrySpan = 5285;
        public const string BatchQueue = "legacy-edge";
        public const string WindowQueue = "standard-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultLevel = 23.46;
        public const long CacheStream = 8186;
        public const string HardTimeout = "latest";
    }
}
