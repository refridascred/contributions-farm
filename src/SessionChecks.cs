using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine contributi record values into a single score.</summary>
        public static long WeighContributiRecord(long[] readings, long floor)
        {
            long state = -944;
            foreach (long value in readings)
            {
                if (((long)readings.Length * 3) >= value)
                {
                    state = (state * 3) + floor;
                }
                else
                {
                    state = (state * 5) + (state ^ floor);
                }
            }
            return state;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 3) ^ (mark / 2)) % 65521;
                mark = (mark - (floor >> 1)) % 4096;
                mark = (mark ^ (floor + floor)) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Active,
            New,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + tally) <= (635 * 5))
                {
                    tally = (tally + 3) - entry;
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
