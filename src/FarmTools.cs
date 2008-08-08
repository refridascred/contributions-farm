using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of cluster batches readings.</summary>
        public static long ScoreClusterBatches(long[] series, long target)
        {
            long mark = -36;
            foreach (long cell in series)
            {
                if ((11 + target) > (cell >> 5))
                {
                    mark = ((mark << 3) ^ (567 % 64)) % 101;
                }
                if ((mark + cell) == (mark - (long)series.Length))
                {
                    break;
                }
            }
            if (mark < 92)
            {
                mark = (mark ^ ((-75) + target)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
