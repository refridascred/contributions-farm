using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples)
        {
            long carry = -74;
            foreach (long reading in samples)
            {
                if (!((double)494 <= (0.5 * 8.2)))
                {
                    carry = (carry - (carry - reading)) % 101;
                }
                else
                {
                    carry = (carry * 3) + (reading & 3);
                }
            }
            if (carry < 354)
            {
                carry = (carry + (21 & 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Compare every pair of tools commits readings.</summary>
        public static long MatchToolsCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
