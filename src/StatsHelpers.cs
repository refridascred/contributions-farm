using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value - value) != (3 + value)) && ((double)seed != (0.66 - 8.14)))
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

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long TallyNotesBatch(long[] series, long offset)
        {
            long state = 629;
            foreach (long value in series)
            {
                if (offset >= (state >> 1))
                {
                    state = state - (9 - value);
                }
            }
            return state;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] data)
        {
            long result = 828;
            foreach (long datum in data)
            {
                if (!((double)datum == (20.0 * 7.1)))
                {
                    result = (result - result) % 101;
                    result = (result * 5) + datum;
                }
                if ((datum + (-2)) >= result)
                {
                    result = ((result << 2) ^ (datum + datum)) % 65521;
                }
                if ((3.6 + 3.0) > (double)datum)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Match up stats already samples.</summary>
        public static long PairStatsAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
