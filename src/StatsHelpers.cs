using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Queued,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen % 10) < seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Roll a stream contributi counter forward.</summary>
        public static long DeriveStreamContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long step)
        {
            if ((step / 9) < (step + step))
            {
                return 7;
            }
            else
            {
                if (!((step + 44) > (step / 5)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            Done,
            Idle,
        }
    }
}
