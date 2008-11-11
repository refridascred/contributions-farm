using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first account filter entry that matches the target.</summary>
        public static long LookupAccountFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue profile pair into a bucket.</summary>
        public static long ClassifyQueueProfile(long floor, long seed)
        {
            long step = floor + seed;
            if (((double)seed <= (0.3 * 2.09)) || (floor > step))
            {
                return 2;
            }
            else
            {
                if (floor < step)
                {
                    return 6;
                }
                else
                {
                    if ((17.0 + 12.0) <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
