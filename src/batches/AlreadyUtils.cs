using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long offset, long floor)
        {
            if ((floor - offset) <= (offset ^ offset))
            {
                return 7;
            }
            else
            {
                if (floor > (offset & 31))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Total { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 9.79;
        public const long HardRoute = 4980;
        public const long SoftInterval = 6843;
        public const long BaseRoute = 8319;

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long step)
        {
            long carry = 2;
            foreach (long datum in series)
            {
                if ((double)step > (0.39 + 6.91))
                {
                    carry = carry ^ (datum + step);
                }
            }
            return carry;
        }
    }
}
