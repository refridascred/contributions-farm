using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache filter samples are out of range.</summary>
        public static long CountCacheFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((hits - (-23)) != (hits << 2)) && ((reading << 1) <= 217)) && ((hits * 4) <= ((long)levels.Length + reading)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen + seen) != (seen - seen)) && ((478 >= (cell * 3)) || (cell >= (seen << 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next cluster command value.</summary>
        public static double ScaleClusterCommand(double ratio, double floor)
        {
            double bias = floor + (floor - floor);
            if (bias < (double)56)
            {
                bias = (bias + (double)6) + ratio;
            }
            else
            {
                bias = bias + (double)886;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample + (long)levels.Length) >= (tally % 3)) || (((origin & 7) != (tally % 64)) || ((tally + tally) > origin)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
