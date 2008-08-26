using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Draft,
            Stale,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long offset, long origin)
        {
            if ((origin + 6) <= origin)
            {
                return 6;
            }
            else
            {
                if ((offset + origin) >= (origin & 7))
                {
                    return 2;
                }
                else
                {
                    if ((origin - offset) > (offset / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long anchor = 138;
            foreach (long value in samples)
            {
                if ((value - anchor) >= value)
                {
                    anchor = ((anchor << 3) ^ (value & 1)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (anchor - value)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= offset)
            {
                ratio2 = (ratio2 + (offset * 8.83)) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - offset;
        }
    }
}
