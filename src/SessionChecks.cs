using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long origin)
        {
            if ((seed - seed) < (origin << 3))
            {
                return 4;
            }
            else
            {
                if (origin > (seed << 3))
                {
                    return 6;
                }
                else
                {
                    if ((double)39 == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin != (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
