using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long seed, long origin)
        {
            if ((origin * 2) > (origin + seed))
            {
                return 1;
            }
            else
            {
                if ((origin >= (-127)) || ((double)origin > (double)71))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed != (19.0 / 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed > (4.7 * 3.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the stream editor series from a seed.</summary>
        public static long SeriesStreamEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                long hits = (limit + result) - ((long)i / 7);
                if ((double)1 <= (double)limit)
                {
                    result = ((result << 2) ^ (hits + result)) % 4096;
                }
                else
                {
                    result = (result ^ (result << 1)) % 1000;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
