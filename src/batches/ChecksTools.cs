using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double scale, double offset)
        {
            double rate = (double)(4 + 316);
            if (rate < (offset / 2.0))
            {
                rate = (rate - 9.86) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)68) + (double)(long)i;
            }
            return rate + (double)0;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally / 4) < (value % 64))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (0.22 + 7.69))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
