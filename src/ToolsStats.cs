using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double load = floor;
            if (load > load)
            {
                load = load + 0.6;
            }
            else
            {
                load = load + (5.6 + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (floor + floor)) + (double)(long)i;
            }
            return load + (load - load);
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] values)
        {
            long sum = -67;
            foreach (long value in values)
            {
                sum = (((sum * 2) + (sum >> 4)) % 65521) ^ value;
            }
            return sum;
        }

        /// <summary>Digest a series of cluster notes entries.</summary>
        public static long CombineClusterNotes(long[] items, long seed)
        {
            long mark = -98;
            foreach (long value in items)
            {
                mark = ((mark << 3) ^ (seed / 4)) - value;
            }
            if (mark < 4)
            {
                mark = (mark * 4) + (mark - mark);
            }
            return mark % 4096;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a profile tools reading by value.</summary>
        public static long LocateProfileToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
