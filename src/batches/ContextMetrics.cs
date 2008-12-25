using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long floor, long seed)
        {
            if (floor >= (floor / 2))
            {
                return 0;
            }
            else
            {
                if ((floor / 9) <= seed)
                {
                    return 1;
                }
                else
                {
                    if ((floor / 5) >= 860)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double ratio = weight;
            if (ratio < offset)
            {
                ratio = ratio - (2.0 / 4.0);
            }
            else
            {
                ratio = ratio - (weight + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio + (weight - weight);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((cell + count) > cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (8.2 >= (double)tally)
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
