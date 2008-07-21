using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate batch report readings against a bound.</summary>
        public static bool ValidateBatchReportBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a session farm value against two limits.</summary>
        public static long SortSessionFarm(long floor, long offset)
        {
            long edge = floor + offset;
            if ((edge / 4) < floor)
            {
                return 2;
            }
            else
            {
                if (((double)edge < (8.4 * 0.6)) && (edge > floor))
                {
                    return 6;
                }
                else
                {
                    if ((999 - offset) <= (offset - edge))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)edge == (10.0 + 7.8)) && ((floor << 1) <= (55 << 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
