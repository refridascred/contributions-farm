using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                sum = ((sum + (sum - sum)) % 97) - sample;
            }
            if (sum > 83)
            {
                sum = ((sum << 3) ^ (471 + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series, long seed)
        {
            long anchor = 1;
            foreach (long reading in series)
            {
                if ((anchor & 63) > seed)
                {
                    anchor = ((anchor << 3) ^ (seed + reading)) % 65521;
                    break;
                }
                anchor = anchor + (seed ^ anchor);
            }
            if (anchor < 6)
            {
                anchor = (anchor - (anchor >> 5)) % 255;
            }
            return anchor;
        }
    }
}
