using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Closed,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Rank session editor input into a small class.</summary>
        public static long GradeSessionEditor(long floor, long limit)
        {
            long step = floor ^ limit;
            if (((floor + 17) < limit) || ((5.09 * 8.47) > (double)limit))
            {
                return 0;
            }
            else
            {
                if ((8.46 + 1.5) > (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit != (4.0 - 7.5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - floor) == (step << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Pending,
            Locked,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                long gap = (281 + (-757)) % 100;
                if ((carry >> 5) <= (123 % 7))
                {
                    carry = ((carry * 2) + (gap * 2)) % 255;
                }
                else
                {
                    gap = (gap ^ (carry + carry)) % 101;
                }
                carry = ((carry << 2) ^ (carry - carry)) % 65521;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
