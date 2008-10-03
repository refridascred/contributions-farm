using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a record stream value against two limits.</summary>
        public static long SortRecordStream(long target, long floor)
        {
            if (!((target << 3) >= (floor / 2)))
            {
                return 5;
            }
            else
            {
                if (target > (target ^ target))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long seed, long seed2)
        {
            if (((double)seed2 != (18.0 - 10.0)) && ((double)9 < (double)seed2))
            {
                return 6;
            }
            else
            {
                if ((3.6 / 9.0) > (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((double)seed2 == (2.0 - 19.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed2 >= (seed2 - 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Stale,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
