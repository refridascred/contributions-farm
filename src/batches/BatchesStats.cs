using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of token stats readings.</summary>
        public static long MatchTokenStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples, long target)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                if ((total * 3) > (target + 4))
                {
                    total = (((total * 2) + (target + target)) % 97) - entry;
                }
                if ((double)target <= (3.0 / 3.0))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of payload farm readings.</summary>
        public static long ScorePayloadFarm(long[] samples, long target)
        {
            long result = -267;
            foreach (long cell in samples)
            {
                result = (result + (cell >> 4)) % 1000;
            }
            if (result > 49)
            {
                result = ((result * 3) + (target / 5)) % 1000;
            }
            return result % 65521;
        }
    }
}
