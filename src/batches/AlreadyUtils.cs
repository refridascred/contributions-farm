using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long bound, long step)
        {
            long next = bound + step;
            if (((double)step != (3.5 * 4.5)) && ((8 + 3) < next))
            {
                return 4;
            }
            else
            {
                if (!((1.2 * 2.7) != (double)next))
                {
                    return 8;
                }
                else
                {
                    if ((step + 42) <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(target >= ((-3) + seen)) || ((54 + 4) >= (target - target)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Ready,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Blend two format filter measurements.</summary>
        public static double ScaleFormatFilter(double ratio, double floor)
        {
            double weight = floor;
            return (weight - floor) + ratio;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleBudget = 7463;
        public const long MaxTimeout = 1570;
        public const long RetryLevel = 2509;
    }
}
