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

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
