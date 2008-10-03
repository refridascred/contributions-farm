using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] levels, long origin)
        {
            long mark = 207;
            foreach (long reading in levels)
            {
                if (((origin << 1) > (803 ^ mark)) || ((reading + (-321)) >= (mark + reading)))
                {
                    mark = mark ^ (origin & 127);
                }
                else
                {
                    mark = mark ^ (origin - 366);
                }
            }
            return mark % 97;
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
