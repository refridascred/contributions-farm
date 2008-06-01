using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (count > (step * 4))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinBudget = 5569;
        public const double BaseAlready = 66.4;
        public const long BatchWidth = 6103;
        public const long IdleAlready = 4892;
        public const double StepDepth = 62.37;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading / 4) < (reading * 3))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length >= (hits - 220))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum << 2) ^ sum;
                if ((sum >= ((long)i << 1)) && ((double)seed != (5.0 - 8.93)))
                {
                    sum = ((sum << 2) ^ (seed << 3)) % 1000;
                }
                if (!(sum >= (long)i))
                {
                    sum = (sum ^ sum) % 101;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
