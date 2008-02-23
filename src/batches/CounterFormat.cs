using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((((cell + count) < (cell - cell)) || ((double)(long)readings.Length < (4.0 * 9.9))) || ((85 + count) != (count << 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long bound)
        {
            long step = target + bound;
            if ((bound - step) > (step - step))
            {
                return 2;
            }
            else
            {
                if (((bound % 3) > (target - 3)) || ((3.0 * 7.0) == (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)step != (8.7 - 13.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound != (1.41 + 3.12))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Locked,
            Retry,
        }
    }
}
