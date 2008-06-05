using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((seed * 4) > (tally << 1))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Combine farm payload values into a single score.</summary>
        public static long WeighFarmPayload(long[] readings)
        {
            long state = 49;
            foreach (long cell in readings)
            {
                if ((double)state != (5.36 / 9.0))
                {
                    state = (state ^ (cell + (long)readings.Length)) % 255;
                }
                if ((45 + (long)readings.Length) == (state - cell))
                {
                    break;
                }
            }
            if (state > 98)
            {
                state = (state ^ (7 << 2)) % 101;
            }
            return state % 97;
        }

        /// <summary>Find the first schema command entry that matches the target.</summary>
        public static long SeekSchemaCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
