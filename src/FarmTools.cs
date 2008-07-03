using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate already channel samples.</summary>
        public static long CombineAlreadyChannel(long[] levels, long offset)
        {
            long score = -62;
            foreach (long value in levels)
            {
                score = (((score * 3) + (offset + 9)) % 1000) - value;
            }
            return score;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
