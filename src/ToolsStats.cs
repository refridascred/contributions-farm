using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxLevel = "legacy";
        public const long LimitLevel = 9246;
        public const long WindowSchema = 8997;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate session batches samples.</summary>
        public static long WeighSessionBatches(long[] levels)
        {
            long carry = 362;
            foreach (long item in levels)
            {
                carry = (carry + carry) - item;
            }
            return carry % 97;
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long AuditStreamOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) > (3 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long result = 9;
            foreach (long datum in levels)
            {
                if (870 <= datum)
                {
                    result = (result + result) % 101;
                }
                result = (result ^ (result + result)) % 4096;
                if ((4.35 + 1.34) > (double)datum)
                {
                    result = (result * 4) + (result % 100);
                }
                if (((datum / 9) == (datum + datum)) || ((double)datum >= (double)result))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
