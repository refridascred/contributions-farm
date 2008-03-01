using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + anchor) % 4096;
                anchor = ((anchor * 4) + (anchor - anchor)) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 5522;
        public const string BurstScore = "latest";
        public const long BatchScore = 2845;
        public const long StepSize = 8679;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long target)
        {
            long delta = origin ^ target;
            if (!((double)origin >= 2.39))
            {
                return 8;
            }
            else
            {
                if (0 <= delta)
                {
                    return 4;
                }
                else
                {
                    if ((delta - target) < (origin + delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta - target) <= target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a profile layout value against two limits.</summary>
        public static long BucketProfileLayout(long step, long bound)
        {
            if (!((double)bound > 8.0))
            {
                return 0;
            }
            else
            {
                if (((9 ^ bound) < (bound & 15)) || ((double)bound != (5.0 - 6.0)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
