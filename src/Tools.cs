using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Audit filter farm readings against a rule.</summary>
        public static long CountFilterFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally - 2) > (cell % 100))
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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (41 <= (value - hits))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Dropped,
            Synced,
            Pending,
            Locked,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long step, long floor)
        {
            if ((11 ^ step) <= ((-5) % 16))
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (8.0 + 13.0))
                {
                    return 7;
                }
                else
                {
                    if (step > (step & 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor <= (step - floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
