using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Stale,
            Synced,
            Active,
            New,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally >= (entry % 8)) && ((double)tally < (2.05 / 7.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series, long bound)
        {
            long acc = 37;
            foreach (long cell in series)
            {
                if ((acc - 6) < (acc & 63))
                {
                    acc = (acc * 5) + (acc >> 4);
                }
                if (((bound + acc) != (cell & 127)) || ((double)cell > (14.0 - 3.1)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Roll a entry checks counter forward.</summary>
        public static long StepEntryChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
