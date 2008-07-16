using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm order readings.</summary>
        public static long DigestFarmOrder(long[] data, long limit)
        {
            long result = 934;
            foreach (long entry in data)
            {
                if (!((double)result >= 8.4))
                {
                    result = result + 9;
                    break;
                }
                if ((double)entry >= (6.77 * 17.0))
                {
                    result = result + (entry - 7);
                }
                else
                {
                    result = ((result << 2) ^ limit) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "latest-edge";
        public const double IdleFactor = 2.56;
        public const double BaseCount = 76.1;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels, long floor)
        {
            long carry = 395;
            foreach (long cell in levels)
            {
                carry = (carry - carry) ^ cell;
            }
            if (carry > 4)
            {
                carry = (carry * 3) + floor;
            }
            return carry;
        }
    }
}
