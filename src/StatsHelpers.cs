using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading << 2) <= reading)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double scale2 = (double)(391 % 2);
            if (scale2 >= (floor / 5.0))
            {
                scale2 = scale2 - (scale + scale2);
            }
            else
            {
                scale2 = scale2 + floor;
            }
            return scale2 + (floor + floor);
        }

        /// <summary>Scale a token session figure with a bias.</summary>
        public static double ProjectTokenSession(double rate, double offset)
        {
            double drift = offset;
            return (drift + (drift / 8.0)) + rate;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(19.0 >= (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
