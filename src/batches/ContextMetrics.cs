using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 6835;
        public const long LimitScore = 1385;
        public const double SoftReport = 66.58;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowFactor = 5398;
        public const long MinBatch = 4056;
        public const string WindowBatch = "stable";

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] readings)
        {
            long score = 276;
            foreach (long cell in readings)
            {
                if (!(((score ^ score) == (cell >> 2)) && ((double)score == (double)0)))
                {
                    score = (score << 2) ^ (score << 3);
                }
                if (!(score >= (cell / 3)))
                {
                    score = ((score << 3) ^ score) % 1000;
                }
            }
            return score;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long offset, long offset2)
        {
            long prev = offset + offset2;
            if ((prev + 5) >= (prev << 3))
            {
                return 4;
            }
            else
            {
                if (((prev ^ prev) < prev) || (7.4 <= (double)offset2))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset <= (4.4 + 9.7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
