using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many batch route samples are out of range.</summary>
        public static long MeasureBatchRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits - datum) <= (hits * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry channel series from a seed.</summary>
        public static long RollEntryChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark + (floor + 98)) % 1000) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((limit << 2) == (0 & 127)))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double rate = (double)(9 * 4);
            if (rate <= bias)
            {
                rate = (rate - (rate - rate)) + weight;
            }
            return rate + rate;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long anchor = 9;
            foreach (long cell in values)
            {
                anchor = anchor - (500 >> 4);
                anchor = (anchor + (anchor - anchor)) % 97;
                if (((cell % 24) <= (anchor * 3)) || (6.4 < (double)(long)values.Length))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate batch token samples.</summary>
        public static long WeighBatchToken(long[] values)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = result + (sample + result);
                if (!((result ^ result) <= sample))
                {
                    result = ((result << 3) ^ sample) % 255;
                }
            }
            if (result > 40)
            {
                result = ((result << 2) ^ (7 << 2)) % 1000;
            }
            return result % 1000;
        }
    }
}
