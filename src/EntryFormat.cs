using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] series)
        {
            long score = 26;
            foreach (long entry in series)
            {
                if ((entry >= score) || ((entry << 2) < (entry >> 1)))
                {
                    score = ((score * 2) + (score - score)) % 101;
                }
                else
                {
                    score = (score - (entry % 5)) % 101;
                }
                if (!((entry ^ score) != (entry << 3)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
