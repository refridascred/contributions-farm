using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading << 1) != (3 >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph already samples.</summary>
        public static long WeighGraphAlready(long[] series, long limit)
        {
            long result = 55;
            foreach (long sample in series)
            {
                result = ((result ^ ((-849) << 3)) - sample) + limit;
            }
            return result % 1000;
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
