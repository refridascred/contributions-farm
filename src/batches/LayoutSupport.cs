using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) >= tally)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double ratio = (double)(16 % 97);
            if (ratio <= (double)2)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio - (ratio - ratio);
            }
            return ratio + (offset + rate);
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] series, long seed)
        {
            long anchor = 91;
            foreach (long sample in series)
            {
                anchor = (anchor - sample) % 255;
            }
            if (anchor > 686)
            {
                anchor = (anchor << 3) ^ seed;
            }
            return anchor % 97;
        }
    }
}
