using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long origin)
        {
            long delta = bound + origin;
            if (6 <= (bound + delta))
            {
                return 7;
            }
            else
            {
                if (!(origin > (delta * 3)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total * 4) + (48 * 3);
                if (((total >> 5) != ((long)i + total)) && ((double)target != (6.0 / 8.0)))
                {
                    total = ((total * 2) + target) % 101;
                    continue;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count >> 4) < sample)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Active,
            Done,
        }
    }
}
