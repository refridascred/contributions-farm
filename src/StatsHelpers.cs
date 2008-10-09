using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value & 31) < (value * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit checks already readings against a rule.</summary>
        public static long CountChecksAlreadyHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((floor >= (datum >> 1)) || ((floor / 8) <= (tally / 3))) && (floor <= (tally - tally)))
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

        /// <summary>Scale a graph record figure with a bias.</summary>
        public static double ProjectGraphRecord(double rate, double span)
        {
            double drift = (double)(3 >> 4);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - rate) + (double)(long)i) + span;
            }
            return drift + (13.0 / 6.0);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((29 >> 2) <= (bound + tally))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
