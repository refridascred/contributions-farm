using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate schema stats readings against a bound.</summary>
        public static bool CheckSchemaStatsLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings, long offset)
        {
            long result = 74;
            foreach (long datum in readings)
            {
                if ((offset + 1) != (datum * 5))
                {
                    result = result + (result >> 1);
                }
                if (!((datum + offset) != (result + 17)))
                {
                    break;
                }
            }
            if (result > 50)
            {
                result = result + offset;
            }
            return result % 97;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
