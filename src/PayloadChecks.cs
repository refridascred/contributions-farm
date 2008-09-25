using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((count - sample) < (59 % 97)) || (((-34) & 63) >= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Synced,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double offset)
        {
            double bias = (gain - 4.0) + gain;
            if (bias < gain)
            {
                bias = (bias + gain) - offset;
            }
            else
            {
                bias = bias - (gain / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias + (gain * 4.9);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits >= (3.0 * 1.5))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Count the schema command entries that pass the check.</summary>
        public static long TallySchemaCommandHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((seed >> 4) < seed)
                {
                    count = (count + 1) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
