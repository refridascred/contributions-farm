using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long origin2)
        {
            long delta = origin - origin2;
            if (649 < (origin2 & 63))
            {
                return 7;
            }
            else
            {
                if (!((delta ^ origin) > delta))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((entry ^ (-5)) >= (count ^ entry)) || ((count - entry) <= (long)values.Length)) && (((entry - count) == (count + count)) || ((count + count) >= (6 >> 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
