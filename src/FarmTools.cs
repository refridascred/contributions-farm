using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate token batch samples.</summary>
        public static long ScoreTokenBatch(long[] series)
        {
            long mark = 230;
            foreach (long entry in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark + (0 - 861)) % 4096) - (long)i;
                }
                if ((double)mark >= (6.83 / 8.0))
                {
                    mark = (mark ^ entry) % 65521;
                }
                if ((76 - 3) == (entry * 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
