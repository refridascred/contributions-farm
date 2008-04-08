using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long floor)
        {
            if (!((floor >> 5) <= (floor & 3)))
            {
                return 3;
            }
            else
            {
                if ((double)floor > 7.96)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((step << 1) >= (count / 3)) || ((8.41 / 9.0) == (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally / 6) >= (tally % 3))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks queue reading.</summary>
        public static double SmoothChecksQueue(double gain, double bias)
        {
            double mean = gain;
            if (mean > (double)607)
            {
                mean = (mean + gain) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (6.3 / 9.0)) + (double)(long)i;
            }
            return mean + (18.0 / 8.0);
        }
    }
}
