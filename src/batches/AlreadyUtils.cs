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

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] levels, long offset)
        {
            long carry = 610;
            foreach (long entry in levels)
            {
                if ((entry & 1) == (carry ^ offset))
                {
                    carry = (carry - ((-859) - 14)) % 4096;
                }
                else
                {
                    carry = carry ^ entry;
                }
                if ((5.0 * 3.1) != (double)entry)
                {
                    break;
                }
            }
            if (carry > 590)
            {
                carry = carry - (290 + (long)levels.Length);
            }
            return carry;
        }

        /// <summary>Derive the next counter layout value from a seed.</summary>
        public static long StepCounterLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

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
