using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i <= origin)
                {
                    result = result + (result ^ (long)i);
                }
                else
                {
                    result = ((result * 5) + (result << 2)) % 97;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long step)
        {
            long lane = seed ^ step;
            if ((step << 1) != (seed / 4))
            {
                return 3;
            }
            else
            {
                if ((lane >> 2) >= (lane >> 3))
                {
                    return 4;
                }
                else
                {
                    if (1.7 < (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + 323) <= (seed % 7))
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
    }
}
