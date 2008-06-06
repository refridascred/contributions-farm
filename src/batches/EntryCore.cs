using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long result = 42;
            foreach (long sample in levels)
            {
                result = (result << 2) ^ (sample / 2);
                if (!((sample & 63) >= (result - sample)))
                {
                    result = ((result << 3) ^ (sample + result)) % 1000;
                }
            }
            if (result < 5)
            {
                result = (result - (result / 4)) % 1000;
            }
            return result;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long target, long bound)
        {
            long edge = target + bound;
            if ((bound - bound) < (target % 16))
            {
                return 0;
            }
            else
            {
                if (!((edge + target) <= (target / 8)))
                {
                    return 2;
                }
                else
                {
                    if (!(3 > edge))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next context support value from a seed.</summary>
        public static long IterateContextSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) >= bound)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
