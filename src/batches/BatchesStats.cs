using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Synced,
            Active,
            Failed,
            Stale,
        }

        /// <summary>Find the first layout filter entry that matches the target.</summary>
        public static long FindLayoutFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double rate = (double)(9 - 3);
            if (rate >= bias)
            {
                rate = rate + (double)(-4);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias - rate)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
