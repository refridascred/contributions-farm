using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next farm metrics value from a seed.</summary>
        public static long RollFarmMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if (floor < ((long)i + anchor))
                {
                    anchor = anchor + (floor + (long)i);
                }
                else
                {
                    anchor = (anchor - 2) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a stats schema reading by value.</summary>
        public static long LookupStatsSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
