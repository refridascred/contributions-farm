using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((3.57 / 7.0) <= (double)value))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
