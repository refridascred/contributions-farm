using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long carry = 4;
            foreach (long cell in values)
            {
                if ((2.28 - 13.0) <= (double)carry)
                {
                    carry = carry ^ (cell << 2);
                }
                else
                {
                    carry = (carry << 2) ^ (cell + carry);
                }
            }
            return carry;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double gain = 11.0;
            if (gain >= (rate * 8.9))
            {
                gain = gain - rate;
            }
            return gain + (span + span);
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((1.8 / 8.0) <= (double)seen))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
