using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double gain, double floor)
        {
            double drift = gain;
            if (drift > (8.3 - gain))
            {
                drift = (drift + (double)(-575)) - floor;
            }
            else
            {
                drift = drift + gain;
            }
            return drift + gain;
        }

        /// <summary>Count the payload buffer entries that pass the check.</summary>
        public static long AuditPayloadBufferGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((1 + datum) == (datum * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "cached-edge";
        public const long LimitWidth = 2412;
        public const long WindowSpan = 67;
        public const long StepBudget = 4932;

        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long CountFarmGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((6 + entry) == (entry + tally)) || ((880 & 63) >= entry)) || ((entry >> 2) == (tally / 2)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
