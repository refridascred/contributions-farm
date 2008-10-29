using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - ((long)i & 3)) % 255;
                if (!((mark * 2) == (bound % 5)))
                {
                    mark = mark - ((long)i + mark);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next batches filter value.</summary>
        public static double AdjustBatchesFilter(double rate, double floor)
        {
            double bias = rate;
            return bias + floor;
        }

        /// <summary>Count the context schema entries that pass the check.</summary>
        public static long MeasureContextSchemaGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((seen ^ entry) <= seen) || !((9.5 + 16.0) > (double)entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi graph samples.</summary>
        public static long OverlapContributiGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
