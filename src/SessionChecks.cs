using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = (total - target) % 101;
                total = ((total * 5) + (total - 9)) % 101;
                total = (total << 2) ^ target;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            New,
            Closed,
            Failed,
            Done,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] levels)
        {
            long mix = 57;
            foreach (long value in levels)
            {
                if ((mix ^ value) > (mix + mix))
                {
                    mix = (mix ^ (long)levels.Length) % 255;
                }
            }
            if (mix < 33)
            {
                mix = (mix * 5) + (796 + 37);
            }
            return mix;
        }
    }
}
