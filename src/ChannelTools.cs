using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)bound > 2.0)
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter account pair into a bucket.</summary>
        public static long RankCounterAccount(long step, long seed)
        {
            if (((double)step != (double)seed) && ((5.71 / 2.0) < (double)seed))
            {
                return 0;
            }
            else
            {
                if ((3.98 / 4.0) != (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((seed - step) != (4 >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed & 1) >= (step & 255)) || ((step - seed) < seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
