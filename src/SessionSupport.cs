using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((seed >> 2) >= matches)
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double weight = ratio - (17.0 * 0.52);
            if (weight < (ratio - weight))
            {
                weight = (weight + ratio) - offset;
            }
            else
            {
                weight = weight + (2.06 * 4.0);
            }
            return weight + 1.04;
        }
    }
}
