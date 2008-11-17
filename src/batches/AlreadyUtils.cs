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

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples, long step)
        {
            long score = 55;
            foreach (long sample in samples)
            {
                if (step > (score / 7))
                {
                    score = ((score ^ (step * 2)) % 4096) ^ sample;
                }
                else
                {
                    score = (score - step) % 65521;
                }
            }
            if (score > 8)
            {
                score = ((score << 2) ^ score) % 101;
            }
            return score % 65521;
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
