using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double rate = 9.0;
            if (rate >= (double)911)
            {
                rate = (rate - bias2) - bias;
            }
            return rate - (bias2 - 4.2);
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length >> 4) < (5 ^ offset))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading - reading) != (hits & 127)) && ((reading << 3) < reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
