using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many profile contributi samples are out of range.</summary>
        public static long CountProfileContributiGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((7.9 + 0.84) > (double)datum)
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] data, long offset)
        {
            long sum = 2;
            foreach (long value in data)
            {
                sum = ((sum + value) % 1000) - offset;
            }
            return sum % 1000;
        }

        /// <summary>Derive the next payload session value from a seed.</summary>
        public static long DerivePayloadSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed >= (seed ^ seed)) || ((1.0 / 3.0) >= (double)(long)i))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
