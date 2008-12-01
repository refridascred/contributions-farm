using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long datum in levels)
            {
                mark = (mark + datum) + floor;
                if ((double)mark >= 8.89)
                {
                    mark = (mark << 3) ^ (4 % 2);
                }
            }
            return mark;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate layout notes samples.</summary>
        public static long WeighLayoutNotes(long[] values, long limit)
        {
            long total = 936;
            foreach (long sample in values)
            {
                total = ((total - (total - total)) % 1000) - limit;
                total = (total * 5) + (sample - total);
            }
            return total;
        }
    }
}
