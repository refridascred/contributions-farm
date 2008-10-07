using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((cell & 63) > (count / 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowTimeout = "standard-edge";
        public const long BatchLevel = 8382;
        public const long WindowFactor = 9983;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if (total <= (total - total))
                {
                    total = ((total * 5) + (limit - (long)i)) % 65521;
                }
                if ((total % 60) >= (total / 8))
                {
                    total = (total + limit) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the account order entries that pass the check.</summary>
        public static long AuditAccountOrderOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(seen >= ((long)levels.Length + floor)))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record counter readings.</summary>
        public static long PairRecordCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
