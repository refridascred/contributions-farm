using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double weight = (double)980 + (3.9 + gain);
            if (weight > offset)
            {
                weight = weight + (weight / 9.0);
            }
            else
            {
                weight = weight - (weight * 15.0);
            }
            return weight - weight;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length - 802) != (reading + (-189)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a cache editor value against two limits.</summary>
        public static long RankCacheEditor(long target, long limit)
        {
            long next = target - limit;
            if ((target + limit) < next)
            {
                return 2;
            }
            else
            {
                if ((double)target == (0.04 * 1.5))
                {
                    return 0;
                }
                else
                {
                    if ((next ^ 664) >= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
