using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Active,
            Paused,
            Idle,
        }

        /// <summary>Iterate the layout record series from a seed.</summary>
        public static long DeriveLayoutRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (offset >> 2);
                mark = ((mark * 4) + 286) % 97;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate report commits samples.</summary>
        public static long FoldReportCommits(long[] levels)
        {
            long acc = 46;
            foreach (long reading in levels)
            {
                acc = (acc ^ (reading << 1)) % 255;
            }
            return acc;
        }

        /// <summary>Iterate the graph route series from a seed.</summary>
        public static long RollGraphRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = (total * 2) + (763 - total);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
