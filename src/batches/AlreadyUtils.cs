using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] samples)
        {
            long result = 89;
            foreach (long sample in samples)
            {
                if ((result + sample) <= (sample << 2))
                {
                    result = ((result * 3) + (result << 3)) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ sample) % 101;
                }
                if ((result % 10) < result)
                {
                    result = (result + (sample ^ result)) % 1000;
                }
            }
            if (result > 312)
            {
                result = ((result * 4) + result) % 97;
            }
            return result % 97;
        }

        /// <summary>Classify a record format pair into a bucket.</summary>
        public static long SortRecordFormat(long floor, long offset)
        {
            long slot = floor - offset;
            if (slot > 26)
            {
                return 0;
            }
            else
            {
                if ((slot + floor) <= floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value < (value & 7)) && (((hits % 2) <= (606 << 3)) && (hits >= (hits + floor))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer cache entries.</summary>
        public static long TotalBufferCache(long[] items, long origin)
        {
            long mark = 545;
            foreach (long item in items)
            {
                mark = ((mark + (origin + (-657))) % 1000) + item;
            }
            if (mark > 94)
            {
                mark = (mark + origin) % 101;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings)
        {
            long score = 7;
            foreach (long sample in readings)
            {
                score = (score + (score + sample)) % 97;
                score = score - score;
            }
            return score;
        }
    }
}
