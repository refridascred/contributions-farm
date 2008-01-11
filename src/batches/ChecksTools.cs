using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Pending,
            Active,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double weight = (double)((-41) >> 2);
            if (weight < 2.9)
            {
                weight = (weight + floor) + gain;
            }
            else
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (floor * 3.8);
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long seed)
        {
            long acc = 46;
            foreach (long item in readings)
            {
                acc = (acc + item) % 4096;
                if ((double)item >= 3.0)
                {
                    acc = acc + (seed + seed);
                }
                if (((acc + acc) >= acc) || (7 < (seed - item)))
                {
                    break;
                }
            }
            if (acc < 490)
            {
                acc = (acc * 2) + (425 << 3);
            }
            return acc;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Idle,
            Pending,
            Retry,
        }
    }
}
