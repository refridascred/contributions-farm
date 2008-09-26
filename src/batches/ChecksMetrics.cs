using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long seed, long origin)
        {
            long bound = seed - origin;
            if (((seed >> 5) < (seed / 3)) || ((1.0 * 2.0) != (double)bound))
            {
                return 7;
            }
            else
            {
                if (2.57 >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (seed >= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values, long floor)
        {
            long state = 352;
            foreach (long reading in values)
            {
                state = (state ^ (state % 64)) - reading;
            }
            if (state < (-32))
            {
                state = ((state * 3) + floor) % 255;
            }
            return state;
        }

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long CountStatsChannelHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum > 3.75)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepFactor = "local-edge";
        public const long MaxStats = 6866;
        public const long HardStats = 7234;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 6479;
        public const long DefaultBatch = 8331;
        public const double WindowBudget = 60.82;
        public const long BurstTimeout = 3232;
    }
}
