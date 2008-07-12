using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((4.16 + 16.0) > (double)entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long limit, long floor)
        {
            if ((limit ^ floor) > limit)
            {
                return 3;
            }
            else
            {
                if (((floor + floor) > floor) || ((limit + limit) < floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor <= (floor + 2)) && ((5.06 * 20.0) != (double)limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long DigestBatchBuffer(long[] series)
        {
            long total = -61;
            foreach (long value in series)
            {
                if ((total & 255) == (value + total))
                {
                    total = (total + (value >> 2)) % 255;
                }
            }
            if (total > 830)
            {
                total = ((total << 3) ^ ((long)series.Length & 7)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next token githubfarm value from a seed.</summary>
        public static long SeriesTokenGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
