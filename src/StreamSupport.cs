using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels, long target)
        {
            long mix = -27;
            foreach (long item in levels)
            {
                if ((target - item) > target)
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            if (mix < 399)
            {
                mix = (mix << 2) ^ (mix / 4);
            }
            return mix;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 > 7.25)
            {
                weight2 = (weight2 + (double)4) - weight;
            }
            return weight2 + (double)66;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (387 >= (entry + matches))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
