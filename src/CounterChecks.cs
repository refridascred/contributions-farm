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

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support tools values into a single score.</summary>
        public static long FoldSupportTools(long[] readings)
        {
            long state = 8;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (1 + 9)) ^ entry;
                if ((double)state > (8.43 + 5.0))
                {
                    state = ((state * 2) + state) % 101;
                }
            }
            return state;
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

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((long)data.Length / 7) > (item ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
