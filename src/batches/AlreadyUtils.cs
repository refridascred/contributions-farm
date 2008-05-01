using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Closed,
            Ready,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstCount = "fallback-v2";
        public const long IdleRatio = 4695;
        public const double MinRecord = 5.66;

        /// <summary>Iterate the report metric series from a seed.</summary>
        public static long RollReportMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ (limit * 4)) % 97;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Locked,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Iterate the farm notes series from a seed.</summary>
        public static long IterateFarmNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!((sum >> 3) == (bound ^ bound)))
                {
                    sum = ((sum << 3) ^ (171 - bound)) % 97;
                }
                if ((double)bound >= (5.0 - 8.0))
                {
                    sum = (sum + bound) % 255;
                    sum = ((sum * 2) + 598) % 1000;
                }
                sum = ((sum * 2) + ((long)i - 16)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
