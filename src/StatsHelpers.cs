using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a batches counter value against two limits.</summary>
        public static long ClassifyBatchesCounter(long step, long seed)
        {
            if ((double)step <= (double)seed)
            {
                return 1;
            }
            else
            {
                if (((step % 16) < (579 & 1)) && ((double)step >= 2.0))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed != (18.0 - 5.07)) || ((double)step >= (double)seed))
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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((double)count != (5.6 - 15.0)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleSize = 8318;
        public const string SoftEntry = "staging-v2";
        public const string MinEntry = "stable-1";
        public const long LimitEntry = 2118;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
