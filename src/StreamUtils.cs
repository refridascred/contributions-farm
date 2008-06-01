using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi order entries.</summary>
        public static long CombineContributiOrder(long[] series, long step)
        {
            long carry = 4;
            foreach (long sample in series)
            {
                if ((double)step < (6.9 * 1.0))
                {
                    carry = ((carry << 3) ^ (step & 15)) + sample;
                }
                if (6.0 > (double)carry)
                {
                    break;
                }
            }
            if (carry > 53)
            {
                carry = (carry ^ step) % 65521;
            }
            return carry;
        }

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
