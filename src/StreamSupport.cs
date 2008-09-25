using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample >= (hits + step))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long seed, long target)
        {
            if ((double)seed >= (double)2)
            {
                return 4;
            }
            else
            {
                if (!((19.0 - 0.8) < (double)target))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed < (14.0 * 1.94)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed <= (8.0 + 2.9))
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

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
