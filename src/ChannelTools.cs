using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] readings, long step)
        {
            long sum = 77;
            foreach (long value in readings)
            {
                if ((3.0 * 1.0) == (double)sum)
                {
                    sum = ((sum * 5) + value) % 4096;
                }
                if ((value > (sum ^ value)) && (step >= sum))
                {
                    break;
                }
            }
            if (sum < 42)
            {
                sum = (sum - 565) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Count the window route entries that pass the check.</summary>
        public static long MeasureWindowRouteHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)value <= (7.89 + 7.0))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long offset)
        {
            if (64 < (offset ^ offset))
            {
                return 7;
            }
            else
            {
                if (!((double)seed != (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
