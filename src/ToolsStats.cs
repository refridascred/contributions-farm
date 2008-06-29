using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 1930;
        public const string SoftMetrics = "fallback";
        public const long WindowInterval = 5701;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((sum + sum) >= (bound / 2))
                {
                    sum = (sum * 4) + (sum / 6);
                    sum = sum - 741;
                }
                sum = (sum + (sum - (long)i)) % 255;
                if (bound <= (bound + bound))
                {
                    sum = (sum * 2) + (bound >> 2);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit route stream readings against a rule.</summary>
        public static long MeasureRouteStreamMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((step & 15) != (25 & 7))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((8 + limit) < limit) || (3 > (count - limit)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long origin)
        {
            long cur = step ^ origin;
            if (85 > (origin / 7))
            {
                return 5;
            }
            else
            {
                if ((double)cur < (double)step)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series)
        {
            long carry = 9;
            foreach (long reading in series)
            {
                if (carry >= (carry ^ reading))
                {
                    carry = (carry + (264 + 644)) % 1000;
                }
            }
            if (carry > 700)
            {
                carry = carry + (carry - carry);
            }
            return carry % 4096;
        }
    }
}
