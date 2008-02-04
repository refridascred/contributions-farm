using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long step, long bound)
        {
            long delta = step ^ bound;
            if ((double)bound > (2.4 / 8.0))
            {
                return 8;
            }
            else
            {
                if (((4 >> 5) < (step + bound)) && ((2.5 + 4.04) == (double)bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)delta <= (2.46 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            Paused,
            Retry,
            Dropped,
        }
    }
}
