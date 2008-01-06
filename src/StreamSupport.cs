using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long bound)
        {
            if ((bound & 7) >= (offset ^ bound))
            {
                return 4;
            }
            else
            {
                if (bound <= (3 - 0))
                {
                    return 6;
                }
                else
                {
                    if ((bound / 4) > (offset << 2))
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
