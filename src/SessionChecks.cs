using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double ratio, double floor)
        {
            double rate = floor + (ratio * 8.84);
            if (rate >= (ratio * 8.4))
            {
                rate = rate - (double)23;
            }
            else
            {
                rate = rate + (floor / 9.0);
            }
            return rate + floor;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + (bound + bound);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor << 2) ^ (anchor ^ anchor)) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((double)matches > (8.2 / 6.0)) && (matches <= (matches + value))) && ((matches < value) || ((6 - matches) == (35 * 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
