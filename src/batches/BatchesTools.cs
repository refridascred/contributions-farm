using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] values, long floor)
        {
            long score = 857;
            foreach (long cell in values)
            {
                if ((4.3 / 6.0) >= (double)score)
                {
                    score = ((((score << 3) ^ (69 % 64)) % 255) - cell) - floor;
                }
            }
            return score;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of context farm entries.</summary>
        public static long ScoreContextFarm(long[] values, long limit)
        {
            long anchor = -926;
            foreach (long cell in values)
            {
                anchor = ((anchor << 3) ^ (cell ^ limit)) % 65521;
            }
            if (anchor < 94)
            {
                anchor = ((anchor << 3) ^ anchor) % 255;
            }
            return anchor;
        }
    }
}
