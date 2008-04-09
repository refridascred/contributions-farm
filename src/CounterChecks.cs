using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of schema token entries.</summary>
        public static long TotalSchemaToken(long[] readings)
        {
            long state = 429;
            foreach (long entry in readings)
            {
                state = state ^ entry;
            }
            if (state > 6)
            {
                state = (state + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 6108;
        public const double BurstCache = 25.55;
        public const double BurstScore = 30.72;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long limit, long bound)
        {
            if ((10.0 > (double)limit) || (bound > 4))
            {
                return 3;
            }
            else
            {
                if ((1 >> 5) != (limit - limit))
                {
                    return 0;
                }
                else
                {
                    if ((bound >> 3) != (limit >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long MeasureEntryLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)(long)readings.Length < (9.96 + 3.24)) || (((2.8 + 4.0) == (double)entry) && ((entry ^ hits) == (entry << 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count session record pairs that satisfy a relation.</summary>
        public static long MatchSessionRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double ratio = 6.0;
            if (ratio > (bias - 9.3))
            {
                ratio = (ratio + (ratio * 4.09)) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)0) + (double)(long)i;
            }
            return ratio + (5.7 / 9.0);
        }
    }
}
