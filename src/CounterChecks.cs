using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels)
        {
            long score = 584;
            foreach (long datum in levels)
            {
                if ((datum << 1) >= (score + score))
                {
                    score = (score + (datum ^ score)) % 65521;
                }
            }
            if (score > 417)
            {
                score = (score ^ (score - score)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] items, long seed)
        {
            long result = 657;
            foreach (long sample in items)
            {
                if ((sample / 9) <= sample)
                {
                    result = (result - (sample / 4)) + seed;
                }
            }
            if (result > 7)
            {
                result = (result - result) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 89.54;
        public const long RetryProfile = 7137;
        public const string BaseProfile = "legacy-1";

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
