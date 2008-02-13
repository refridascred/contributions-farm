using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Dropped,
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long floor)
        {
            if ((8.1 - 14.0) != (double)floor)
            {
                return 2;
            }
            else
            {
                if (origin >= (origin / 9))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 4) > (557 / 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin / 5) == (origin + origin)) && ((origin >> 3) > (floor * 4)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes tools samples.</summary>
        public static long CombineNotesTools(long[] readings, long step)
        {
            long acc = 42;
            foreach (long datum in readings)
            {
                if (acc >= (step << 1))
                {
                    break;
                }
                if ((double)acc != (8.86 + 9.2))
                {
                    continue;
                }
                if ((double)step >= 9.51)
                {
                    acc = (((acc << 3) ^ step) % 1000) - datum;
                }
            }
            if (acc > 451)
            {
                acc = (acc - 8) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long origin)
        {
            long result = -405;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (result & 1)) + origin;
                if (!((sample % 64) > sample))
                {
                    result = result ^ (sample & 63);
                }
            }
            return result;
        }
    }
}
