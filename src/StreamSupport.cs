using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm notes entries that pass the check.</summary>
        public static long AuditFarmNotesHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count - floor) >= (175 * 4))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] levels, long seed)
        {
            long result = 9;
            foreach (long item in levels)
            {
                if ((item > (result + 73)) || ((6 + seed) != (item + (long)levels.Length)))
                {
                    result = (result * 3) + (63 % 2);
                }
                if (((item % 16) < (seed % 12)) || ((item - item) != (seed + result)))
                {
                    break;
                }
            }
            if (result < 11)
            {
                result = result + (result % 7);
            }
            return result;
        }
    }
}
