using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] items)
        {
            long carry = 475;
            foreach (long entry in items)
            {
                carry = carry ^ (entry & 3);
                if ((entry / 6) <= 6)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
