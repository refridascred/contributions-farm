using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate buffer cache samples.</summary>
        public static long WeighBufferCache(long[] samples)
        {
            long score = 281;
            foreach (long value in samples)
            {
                if ((value + value) == (value - score))
                {
                    score = (score - score) % 255;
                }
            }
            if (score > 740)
            {
                score = (score ^ (score + score)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry - 34) != (seed / 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "stable-1";
        public const long DefaultTimeout = 1761;
        public const string BaseFactor = "primary-1";

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long origin)
        {
            long edge = offset - origin;
            if ((origin + edge) >= (edge / 8))
            {
                return 2;
            }
            else
            {
                if (((offset & 63) < (-2)) && (150 >= (offset + origin)))
                {
                    return 1;
                }
                else
                {
                    if (!((origin + 681) != (origin - origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream graph readings.</summary>
        public static long PairStreamGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
