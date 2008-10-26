using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 4253;
        public const string MinTimeout = "strict-1";
        public const double StepTimeout = 44.43;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit graph order readings against a rule.</summary>
        public static long AuditGraphOrderOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry <= (1 & 1))
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + tally) >= (sample % 97))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of commits notes entries.</summary>
        public static long TotalCommitsNotes(long[] levels)
        {
            long carry = 3;
            foreach (long cell in levels)
            {
                carry = carry + (190 + carry);
                if (!((carry << 3) <= (cell + (long)levels.Length)))
                {
                    carry = carry - (877 * 3);
                }
            }
            return carry;
        }
    }
}
