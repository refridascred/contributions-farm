using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the editor stats entries that pass the check.</summary>
        public static long CountEditorStatsOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((origin * 3) < (entry - 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long step, long floor)
        {
            if ((step + 61) >= (3 + floor))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (7.0 * 17.0))
                {
                    return 3;
                }
                else
                {
                    if ((floor + step) >= (step + 60))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double scale = (bias * 2.3) - (5.3 / 7.0);
            return (scale - (double)99) + offset;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Closed,
            Active,
            Done,
        }

        /// <summary>Locate a batch entry reading by value.</summary>
        public static long LookupBatchEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((66 - origin) != (8 + reading)) || ((reading & 63) >= (tally ^ origin)))
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
